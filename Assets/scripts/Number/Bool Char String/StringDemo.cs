using UnityEngine;

// string(문자열) = 문자(배)열 데이터 형식 

public class StringDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 문자열 변수 선언하고 홍길동으로 초기화

        string name = "홍길동";

        //[1] 사용하기
        Debug.Log("안녕하세요 " + name + " 입니다.");

        string multiLine = @"
                안녕하세요
                반갑습니다

        ";

        Debug.Log(multiLine);
        
    }

  
}
