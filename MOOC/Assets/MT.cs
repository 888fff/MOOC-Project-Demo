using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MT : MonoBehaviour
{
    Animator animator;
    public Transform rightFoot;
    AnimatorStateInfo animState;
    public float matchStart;
    public float matchEnd;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator != null)
        {
            animState = animator.GetCurrentAnimatorStateInfo(0);
            if (Input.GetButton("Fire1")) animator.SetTrigger("jump");
            if (animState.IsName("JUMP00"))
            {
                animator.SetTrigger("jump");
                animator.MatchTarget(rightFoot.position,rightFoot.rotation,AvatarTarget.RightFoot,
                    new MatchTargetWeightMask(Vector3.one,1),matchStart,matchEnd);
            }
        }
    }
}
