using UnityEngine;

//1���� 10������ ���� �� ¦���� ���� ���ϴ� ���α׷� ����
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
        //    if (i % 2 == 0) // ¦�� �Ǻ����
        //        sum = sum + i;


        //}
        //    Debug.Log(sum);

    }

   
}
