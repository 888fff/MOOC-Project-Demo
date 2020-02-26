using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C5_Test : MonoBehaviour
{
    public float speed = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
