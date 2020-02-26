using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C14_L3 : MonoBehaviour
{
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("car");
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.position = obj.transform.position + Vector3.one;
    }

    WaitForSeconds ws = new WaitForSeconds(1);

    IEnumerator WaitSec()
    {
        yield return ws;
    }
}
