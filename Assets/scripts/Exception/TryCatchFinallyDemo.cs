using UnityEngine;

public class TryCatchFinallyDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 5;
        int y = 5;
        int result = 0;

        try //예외가 발생할 가능성이 있는 명령문
        {
            //[1]
            result = x / y;
            Debug.Log($"{x} / {y} = {result}");
        }
        catch  // try 절에서 예외가 발생하면 catch절을 실행
        {
            //[2]
            Debug.Log("예외가 발생 했습니다");
        }
        finally // try 절에서 예외가 발생하든 안하든 상관없이 실행
        {
            //[3]
            Debug.Log("프로그램을 종료합니다");
        }
        //try 절에서 예외가 발생하면 : [1] -> [2] -> [3]
        //try 절에서 예외가 발생안하면 : [1] -> [3]

    }


}
