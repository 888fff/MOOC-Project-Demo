using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IK2 : MonoBehaviour
{
    protected Animator animator;
    public Transform target;
    public Transform hint;
    public bool isHand = true;
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
        AvatarIKGoal g = isHand ? AvatarIKGoal.RightHand : AvatarIKGoal.RightFoot;
        AvatarIKHint h = isHand ? AvatarIKHint.RightElbow : AvatarIKHint.RightKnee;
        animator.SetIKPositionWeight(g,1f);
        animator.SetIKPosition(g, target.position);
        animator.SetIKRotationWeight(g, 1f);
        animator.SetIKRotation(g, target.rotation);

        animator.SetIKHintPositionWeight(h, 1f);
        animator.SetIKHintPosition(h, hint.position);
    }
}
