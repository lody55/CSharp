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
            if( i % 3 ==0) //>>>>>>>>>>>>>>>>>>>> if(i % 3 ==0 || i % 4 ==0) �ϸ� ���� ȿ��
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
1���� 100������ ���� �߿��� 3�� ��� �Ǵ� 4�� ����� ���ؼ� ���ϴ� ���α׷�

[out put]
���� {}
 */