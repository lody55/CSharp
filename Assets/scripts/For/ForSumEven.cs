using UnityEngine;

//1부터 10까지의 정수 중 짝수의 합을 구하는 프로그램 구현
public class ForSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int n = 10;
        int sum = 0;

        // 2 + 4 + 6 + 8 + 10

        for (int i = 0; i < 11; i = i + 2)
        {
            sum = sum + i;
        }
        Debug.Log(sum);

        //for (int i = 1; i < n+1; i = i ++)
        //{
        //    if (i % 2 == 0) // 짝수 판별기능
        //        sum = sum + i;


        //}
        //    Debug.Log(sum);

    }

   
}
