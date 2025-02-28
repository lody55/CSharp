using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string num = "3";
        string message = "홀수 입니다";

        Debug.Log(num + "은 "+ message);

    }


}


/*
 [문제]
3, 홀수를 변수선언하고 저장 합니다
문자열 보간법을 이용해서 저장된 데이터 출력하기

[output]
3은 ( 는) 홀수 입니다 

 */