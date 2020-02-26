using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timeline_Controller : MonoBehaviour
{
    [SerializeField]
    public UnityEvent tl_event;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tl_event.Invoke();
        }
    }
}
