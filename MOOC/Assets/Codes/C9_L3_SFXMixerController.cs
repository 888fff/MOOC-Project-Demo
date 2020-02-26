using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class C9_L3_SFXMixerController : MonoBehaviour
{
    public AudioMixer audioMixer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v;
        audioMixer.GetFloat("VolumeParam", out v);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            audioMixer.SetFloat("VolumeParam", v + 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            audioMixer.SetFloat("VolumeParam", v - 1);
        }
    }
}
