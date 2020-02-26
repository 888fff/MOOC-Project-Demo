using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C14_L2_2 : MonoBehaviour
{
    public GameObject role;
    private GameObject cloned;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            cloned = Instantiate(role,new Vector3(0,0,-4),Quaternion.identity) as GameObject;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(cloned);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (cloned) cloned.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (cloned) cloned.SetActive(false);
        }
    }
}
