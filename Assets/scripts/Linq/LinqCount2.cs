using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class LinqCount2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bool형 배열 변수에서 true값의 갯수, false 값의 갯수 구하기
        bool[] blns = { true, false, true, false, true };

        //전체 요소수 구하기
        Debug.Log(blns.Count());

        //true값의 갯수
        Debug.Log(blns.Count(b => b == true));
        //false값의 갯수
        Debug.Log(blns.Count(a => a == false));

    }


}
