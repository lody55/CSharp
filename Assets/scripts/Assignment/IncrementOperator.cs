using UnityEngine;

// IncrementOperator(증가 연산자)
public class IncrementOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 100;
        // 1 증가식
        num = num + 1;
        // 축약(누적 증가식)
        num += 1;

        // 증가연산자
        ++num;
        Debug.Log("num : "+num);

        --num;
        Debug.Log(num);

                
        
    }

 
}
