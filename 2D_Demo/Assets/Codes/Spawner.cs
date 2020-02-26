using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timeInterval = 3f;
    float timer = 0f;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > timeInterval)
        {
            Instantiate(bullet, transform);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
