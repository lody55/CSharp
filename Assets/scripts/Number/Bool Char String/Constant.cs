using UnityEngine;

public class Constant : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //변수 
        string name = "홍길동";
        name = "이순신";  // 수정가능 함 > 변수기 때문
        
        //상수
        const int Age = 20;
        //Age = 21;  // 수정 불가능 > 상수기 때문


        //변수 , 상수 사용
        Debug.Log($"{name} - {Age}");

    }


}
