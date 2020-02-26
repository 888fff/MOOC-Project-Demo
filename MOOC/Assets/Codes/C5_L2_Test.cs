using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C5_L2_Test : MonoBehaviour
{
    public int hp;
    public float driveForce;
    public GameObject target;
    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log("Awake here");
    }
    void Start()
    {
        Debug.Log("Start here");

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);
    }

    private void FixedUpdate()
    {
        /*
        Vector3 force = transform.forward * driveForce * Input.GetAxis("Vertical");
        GetComponent<Rigidbody>().AddForce(force);
        */
    }

    private void LateUpdate()
    {
        Camera.main.transform.LookAt(target.transform);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Arraw")
        {
            hp = hp - 10;
        }
    }
}
