using UnityEngine;

//안녕하세요를 3번 실행하는 프로그램
public class Dowhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int i = 1;

        //while (i<=3)
        //{
        //    Debug.Log("안녕하세요");

        //    i++;
        //}

        int i = 1;

        do
        {
            //반복실행문
            Debug.Log("안녕하세요");

            //[2] 증감식
            i++;

        } while (i <= 3); //[3] 조건식

        //for(int i = 1; i<=3; i++)
        //{
        //    Debug.Log($"안녕하세요");
        //}
    } 
}
/*
 DoWhile문 = 반복문

먼저 반복 실행문을 1번 실행한다
조건식이 true이면 반복문을 실행한다
조건식이 false면 while문을 종료한다

do (무조건 한번 실행한 후 다음 while 조건식으로 넘어감)
{
    //반복 실행문
} While(조건식)

 */
