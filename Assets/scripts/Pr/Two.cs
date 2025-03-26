using System.Linq;
using UnityEngine;

public class Two : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] num = { -2, -5, -3, -7, -1 };


        int min = num[0];
        foreach(var s in num)
        {
            if (s < min)
            {
                min = s;
            }
        }
        Debug.Log($"최소값 : {min}");
    }

  
}
