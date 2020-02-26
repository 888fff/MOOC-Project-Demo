using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class C5_L4_Test : MonoBehaviour
{
    [Serializable]
    public class Node
    {
        public string value;
        public List<Node> children = new List<Node>();
    }
    public Node root = new Node();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
