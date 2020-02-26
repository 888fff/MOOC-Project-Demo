using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AI_Enemy : MonoBehaviour
{
    public float patrolSpeed = 2f;
    public float patrolWaitTime = 1f;
    public Transform patrolWayPoints;
    private NavMeshAgent agent;
    private float patrolTimer;
    private int wayPointIndex;
    public float shootRotSpeed = 5f;
    public float shootFreeTime = 2f;
    private float shootTimer = 0f;
    private AI_EnemySight enemySight;
    public Rigidbody bullet;
    private Transform player;
    public bool chase;
    public float chaseSpeed = 5f;
    public float chaseWaitTime = 5f;
    private float chaseTimer;
    public float sqrPlayerDist = 3f;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        enemySight = transform.Find("ViewRange").GetComponent<AI_EnemySight>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemySight.playerInSight)
        {
            Shooting();
            chase = true;
        }
        else if (chase)
        {
            Chasing();
        }
        else
        {
            Patrolling();

        }


    }

    void Shooting()
    {
        Vector3 lookPos = player.position;
        lookPos.y = transform.position.y;
        Vector3 targetDir = lookPos - transform.position;
        transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(targetDir),
            Mathf.Min(1,Time.deltaTime * shootRotSpeed));
        agent.isStopped = true;
        if (Vector3.Angle(transform.forward,targetDir) < 2)
        {
            if (shootTimer > shootFreeTime)
            {
                Instantiate(bullet, transform.position, Quaternion.LookRotation(player.position - transform.position));
                shootTimer = 0;
            }
            shootTimer += Time.deltaTime;
        }
    }

    void Chasing()
    {
        agent.isStopped = false;
        Vector3 sightingDeltaPos = enemySight.personalLastSight - transform.position;
        if (sightingDeltaPos.sqrMagnitude > sqrPlayerDist)
        {
            agent.destination = enemySight.personalLastSight;
        }
        agent.speed = chaseSpeed;
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            chaseTimer += Time.deltaTime;
            if (chaseTimer >= chaseWaitTime)
            {
                chase = false;
                chaseTimer = 0f;
            }
        }
        else
        {
            chaseTimer = 0;
        }
    }

    void Patrolling()
    {
        agent.isStopped = false;
        agent.speed = patrolSpeed;
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            patrolTimer += Time.deltaTime;
            if (patrolTimer >= patrolWaitTime)
            {
                if (wayPointIndex == patrolWayPoints.childCount - 1)
                {
                    wayPointIndex = 0;
                }
                else
                {
                    wayPointIndex++;
                }
                patrolTimer = 0;
            }          
        }
        else
        {
            patrolTimer = 0;
        }

        agent.destination = patrolWayPoints.GetChild(wayPointIndex).position;
    }
}
