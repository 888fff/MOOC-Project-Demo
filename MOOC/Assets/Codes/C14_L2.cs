using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C14_L2 : MonoBehaviour
{
    public Transform Cubes;
    void Awake()
    {
        for (int i = Cubes.childCount - 1; i >= 0; i--)
        {
            Cubes.GetChild(i).gameObject.AddComponent<C14_L2_Cube>();
        }
    }
}
