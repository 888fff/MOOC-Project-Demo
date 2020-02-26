using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C9_L2_MixerController : MonoBehaviour
{
    public AudioSource shootSnd;
    public AudioSource explodeSnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shootSnd.Play();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            explodeSnd.Play();
        }
    }
}
