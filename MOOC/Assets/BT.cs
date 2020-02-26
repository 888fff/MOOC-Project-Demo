using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class BT : MonoBehaviour
{
    Animator animator = null;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        float v = CrossPlatformInputManager.GetAxis("Vertical");
        Vector3 move = v * Vector3.forward + h * Vector3.right;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            move.z *= 0.5f;
        }
        float turn = move.x;
        float forward = move.z;
        animator.SetFloat("speed", forward,0.1f,Time.deltaTime);
        animator.SetFloat("turn", turn, 0.1f, Time.deltaTime);


    }
}
