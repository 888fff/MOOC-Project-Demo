using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C5_L3_Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Called Start");
    }
    private void Awake()
    {
        Debug.Log("Called Awake");

    }
    private void OnEnable()
    {
        Debug.Log("Called OnEnable");

    }
    private void OnLevelWasLoaded(int level)
    {
        Debug.Log("Called OnLevelWasLoaded");

    }
    private void OnApplicationPause(bool pause)
    {
        Debug.Log("Called OnApplicationPause");

    }
    private void OnPreCull()
    {
        Debug.Log("Called OnPreCull");

    }
    private void OnWillRenderObject()
    {
        Debug.Log("Called OnWillRenderObject");

    }
    private void OnPreRender()
    {
        Debug.Log("Called OnPreRender");

    }
    private void OnPostRender()
    {
        Debug.Log("Called OnPostRender");

    }
    private void OnDestroy()
    {
        
    }
    private void OnApplicationQuit()
    {
        
    }
    private void OnDisable()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
