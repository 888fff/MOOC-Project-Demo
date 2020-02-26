using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.SendMessage("GetDamage",60,SendMessageOptions.DontRequireReceiver);
    }
}
