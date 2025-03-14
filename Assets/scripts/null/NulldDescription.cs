using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class NullDiscription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //값 형식
        

        //참조형식
        string s = null;
        s = "안녕하세요";
        

        Debug.Log(s); 
    }

 
}

/*
Null( Null , null)
아무것도 없는 상태 , 아무것도 없음을 의미하는 리터럴
인스턴스 (객체)가 아무것도 참조하지 않음, null 참조

(값 형식) x 1234
(참조 형식) s --------> "안녕하세요"
(참조 형식) o ------ 참조할 데이터가 없음 == null
참조형 변수(o)에 아무런 값도 설정하지 않음, null 참조
string의 ""(빈 값, empty) 과 null은 다름 

 */