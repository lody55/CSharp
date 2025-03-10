using UnityEngine;

//
public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //3,5를 입력받아 큰 수를 출력하기
        int max = GetMax(3, 5);
        Debug.Log($"3과 5중 큰 수는? {max}입니다.");

        int min = Getmin(-3, -5);
        Debug.Log($"-3과 -5중 작은 수는? {min}입니다.");

    }

    //1. 매개변수로 입력 받은 두 개의 정수 중 큰 수를 반환하는 함수
    int GetMax(int x , int y)
    {
        //int maxvalue;
        //if(x>y)
        //{
        //    maxvalue = x;
        //}
        //else
        //{
        //    maxvalue = y;
        //}
        //return maxvalue;
        //3항 연산자
        //int maxvalue = (x > y) ? x : y;
        //return maxvalue;
        //return (x > y) ? x : y;
        if(x > y)
        {
            return x;
        }    
        else
        {
            return y;
        }
    }

    int Getmin(int x, int y)
    {
        if(x <y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }    
    
}

/*
 [Q]
1. 매개변수로 입력 받은 두 개의 정수 중 큰 수를 반환하는 함수
2. 매개변수로 입력 받은 두 개의 정수 중 작은 수를 반환하는 함수
3. 3,5를 입력받아 큰 수 출력하기
4. -3 , -5를 입력받아 작은 수 출력하기
 
[output]
3과 5중 큰 수는 (반환 값) 이다
-3과 -5 중 작은 수는 (반환 값) 이다

 
 */