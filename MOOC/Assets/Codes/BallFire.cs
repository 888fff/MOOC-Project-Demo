using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFire : MonoBehaviour
{
    public GameObject bullet;
    static float pressTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            pressTime += Time.deltaTime;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            GameObject b = Instantiate(bullet,ray.origin,Quaternion.LookRotation(ray.direction)) as GameObject;
            var cf = b.GetComponent<ConstantForce>().relativeForce = new Vector3(0, 0, pressTime * 10);
            pressTime = 0;
        }
    }
}
