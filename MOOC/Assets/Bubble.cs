using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public Transform bubble;
    public Vector3 origianlScale;
    // Start is called before the first frame update
    void Start()
    {
        origianlScale = bubble.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        var curve = GetComponent<Animator>().GetFloat("CurveValue");
        bubble.localScale = new Vector3(origianlScale.x + curve, origianlScale.y + curve, origianlScale.z + curve);
    }
}
