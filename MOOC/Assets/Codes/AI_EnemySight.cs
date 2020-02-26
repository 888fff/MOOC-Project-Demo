using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_EnemySight : MonoBehaviour
{
    public float fieldOfViewAngle = 120f;
    public bool playerInSight;
    public Vector3 personalLastSight;
    public static Vector3 resetPos = Vector3.back;
    BoxCollider col;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
        player = GameObject.FindGameObjectWithTag("Player");
        personalLastSight = resetPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInSight = false;
            Vector3 direction = other.transform.position - transform.position;
            float angle = Vector3.Angle(direction,transform.forward);
            if (angle < fieldOfViewAngle * 0.5f)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position,direction.normalized,out hit,col.size.z))
                {
                    if (hit.collider.gameObject == player)
                    {
                        Debug.Log("I saw the player!");
                        playerInSight = true;
                        personalLastSight = player.transform.position;
                    }
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInSight = false;
        }
    }
}
