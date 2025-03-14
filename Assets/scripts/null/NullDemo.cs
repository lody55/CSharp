using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


public class NullDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Null가능 값 형식
        //bool bln = null; = 불가능
        Nullable<bool> bln = null;
        Debug.Log(bln.HasValue);
        bln = false;
        Debug.Log(bln.HasValue);

        //Nullable<int> -> int?
        //Nullable<float> --> float?
        //Nullable<int> ni = null;
        int? ni = null;
        ni = 10;
        Debug.Log(ni);
        

        
    }

}
