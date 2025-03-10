using UnityEngine;

// break; : 반복문에서 (for,while)에서 {}를 빠져나오는 명령문
// 반복문 안에서 break;문을 만나면 즉시 반복문을 종료한다

public class BreakFo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //안녕하세요를 5번 출력하는 프로그램
        // i = 2일때 for문을 종료
        for (int i = 1; i <= 5; i++)
        {
            //반복 실행문
            Debug.Log("안녕하세요");

            if (i == 2)
            {
                break;
            }
        }

        // 조건문 참 >> 출력 >> if값 거짓 >> 조건문 참 >> 출력 if값 true >>브레이크 실행 >> for문 종료

    }
}
