using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C7_L5_Water : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<C7_L5_Floater>())
        {
            other.gameObject.GetComponent<C7_L5_Floater>().SetIsInWater(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<C7_L5_Floater>())
        {
            other.gameObject.GetComponent<C7_L5_Floater>().SetIsInWater(false);
        }
    }
}
