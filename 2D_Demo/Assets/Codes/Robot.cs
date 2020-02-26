using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public float m_MaxSpeed = 10f;
    public float m_JumpForce = 400f;
    public LayerMask m_WhatIsGround;

    public Transform m_GroundCheck;
    const float k_GroundedRadius = 0.5f;
    public bool m_Grounded;
    private Animator m_Anim;
    private Rigidbody2D m_Rigidbody2D;
    public bool m_FacingRight = true;
    public bool m_Jump;
    // Start is called before the first frame update
    private void Awake()
    {
        m_GroundCheck = transform.Find("GroundCheck");
        m_Anim = GetComponent<Animator>();
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        m_Grounded = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position,k_GroundedRadius,m_WhatIsGround);
        for (int i = 0;i<colliders.Length;++i)
        {
            if (colliders[i].gameObject != gameObject)
            {
                m_Grounded = true;
            }
        }

        m_Anim.SetBool("ground",m_Grounded);
        float h = Input.GetAxis("Horizontal");
        if (!m_Jump)
        {
            m_Jump = Input.GetKeyDown(KeyCode.Space);
        }
        Move(h, m_Jump);
        m_Jump = false;
    }

    public void Move(float move,bool jump)
    {
        if (m_Grounded)
        {
            m_Anim.SetFloat("speed",Mathf.Abs(move));
            m_Rigidbody2D.velocity = new Vector2(move * m_MaxSpeed,m_Rigidbody2D.velocity.y);
            if (move > 0 && !m_FacingRight)
            {
                Flip();
            }
            else if (move < 0 && m_FacingRight)
            {
                Flip();
            }
        }

        if (m_Grounded && jump && m_Anim.GetBool("ground"))
        {
            m_Grounded = false;
            m_Anim.SetBool("ground", false);
            m_Rigidbody2D.AddForce(new Vector2(0, m_JumpForce));
        }
    }
    void Flip()
    {
        m_FacingRight = !m_FacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
