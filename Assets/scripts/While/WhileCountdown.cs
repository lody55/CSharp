using UnityEngine;

// 1, 2, 3, 4, 5
// 5, 4, 3, 2, 1
public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1부터 5까지 1씩 증가
        //초기식
        int i = 1;

        while (i <= 5) //조건식
        {
            //반복 실행문
            Debug.Log($"카운트 다운 : " +i);

            //증감식
            i++;
        }
        Debug.Log(" ====================================");

        //[2] 5부터 1까지 1씩 감소
        //초기식
        int y = 5;

        while (y >= 1)
        {
            Debug.Log($"카운트 다운 : " + y);

            y--;


        }
                
    }

}
