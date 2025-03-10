using UnityEngine;

public class WhileDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        //for(int i = 0; i < 3; i++) 반복횟수 3 - 0
        //for(int i = 1; i < 4; i++ ) 반복횟수 : 4 - 1
        //for(int i = 1; i <= 3; i++ )반복횟수 : 3 - 1 + 1
        //(for(초기식;조건식;증감식)
        for (int i = 0; i < 3; i++)
        {
            //반복 실행문
            Debug.Log("안녕하세요");

        }
        //[1] 초기식
        int o = 0;
        while (o<3) //[2] 조건식
        {
            //반복 실행문
            Debug.Log("안녕하세요");



            //증감식
            o++;
        }    
    }


}
/*
 while문 - 반복문 
조건식이 true이면 반복문 실행 , false면 while문 종료

while(조건식)
{
    반복 실행문 
    
    조건식에 들어가는 변수 증감식
}

조건식 판별(참) >>> 반복문 실행 >>> 조건식 판별(참) >>>> 반복문 실행 >>>> 조건식 판별(거짓) >>>> while문 종료


 */