using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C7_L3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnJointBreak(float breakForce)
    {
        Debug.Log("you destoried " + name + " with a force "+ breakForce);
    }
}
