using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IK : MonoBehaviour
{
    protected Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnAnimatorIK(int layerIndex)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float enter = 0f;
        Plane plane = new Plane(Vector3.up,transform.position);
        Vector3 target;
        if (plane.Raycast(ray,out enter))
        {
            target = ray.GetPoint(enter);
            animator.SetLookAtWeight(0.5f,0.3f,0.8f,1);
            animator.SetLookAtPosition(target);
        }
    }
}
