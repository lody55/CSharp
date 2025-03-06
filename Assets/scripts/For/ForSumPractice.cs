using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ForSumPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;
        int n = 100;
        for(int i = 1; i < n+1; i++ )
        {
            if( i % 3 ==0) //>>>>>>>>>>>>>>>>>>>> if(i % 3 ==0 || i % 4 ==0) 하면 같은 효과
            {
                sum = sum + i;
            }
            else if(i % 4 ==0)
                sum = sum + i;
            

        }
        Debug.Log(sum);
    }
    

     
}

/*
 [Q]
1부터 100까지의 정수 중에서 3의 배수 또는 4의 배수를 구해서 합하는 프로그램

[out put]
합은 {}
 */