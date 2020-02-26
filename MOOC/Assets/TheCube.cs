using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheCube : MonoBehaviour
{
    public float RotateSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, RotateSpeed * Time.deltaTime);
    }
}
