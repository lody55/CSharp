using UnityEngine;

// 1부터 100까지의 정수중에서 3의 배수르 제외한 합을 구하는 프로그램 구현
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
