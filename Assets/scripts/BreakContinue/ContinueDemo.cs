using UnityEngine;

// 1���� 100������ �����߿��� 3�� ����� ������ ���� ���ϴ� ���α׷� ����
public class ContinueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;
        

        for(int i = 1; i <=n; i++)
        {
            
            if(i % 3 == 0)
            {
                continue;
            }
            sum = sum + i;
        }
        Debug.Log(sum);
    }

}
