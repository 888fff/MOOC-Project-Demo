using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerControl : MonoBehaviour
{
    Animator anima = null;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float w = anima.GetLayerWeight(1) > 1 ? 1 : anima.GetLayerWeight(1) + speed * Time.deltaTime;
            anima.SetLayerWeight(1, w);
        }
        else
        {
            float w = anima.GetLayerWeight(1) < 0 ? 0 : anima.GetLayerWeight(1) - speed * Time.deltaTime;
            anima.SetLayerWeight(1, w);

        }
    }
}
