using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C7_L5_Floater : MonoBehaviour
{
    private bool isInWater;
    private GameObject water;
    private float waterY;
    //private const float floatageForce = 0;
    public float density = 1;
    public float g = 9.8f;
    public float waterDrag = 5;
    // Start is called before the first frame update
    void Start()
    {
        isInWater = false;

        water = GameObject.FindWithTag("Water");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (isInWater)
        {
            calFloatage();

            GetComponent<Rigidbody>().drag = waterDrag;
        }
    }

    void calFloatage()
    {
        waterY = water.transform.position.y + water.transform.localScale.y /2;
        if (waterY > (transform.position.y - transform.localScale.y))
        {
            float h = waterY - (transform.position.y - transform.localScale.y / 2) > transform.localScale.y ?
                transform.localScale.y : waterY - (transform.position.y - transform.localScale.y/2);
            float floatageForce = density * g * transform.localScale.x * transform.localScale.z * h;
            GetComponent<Rigidbody>().AddForce(0, floatageForce,0);
        }
    }

    public void SetIsInWater(bool inWater)
    {
        isInWater = inWater;
    }

    public bool GetIsInWater()
    {
        return isInWater;
    }
}
