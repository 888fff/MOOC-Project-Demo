using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C5_L5_Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine("Fade");
        }
    }

    IEnumerator Fade()
    {
        for (float f = 1f;f>=0;f-=0.1f)
        {
            Color c = GetComponent<MeshRenderer>().material.color;
            c.a = f;
            GetComponent<MeshRenderer>().material.color = c;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
