using UnityEngine;

public class ArrayTwoTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //2차원 배열 선언 , 요소 수 생성, 초기화

        //int[,] intArray = new int[2, 3] { {1,2,3 },{4,5,6 } };
        //2차원 배열 선언, 요소 수 생성(생략) , 초기화
       // int[,] intArray = new int[, ] { { 1, 2, 3 }, { 4, 5, 6 } }; // new int[,]만 입력하면 자동으로 입력이 된다

        int[,] intArray = { { 1, 2, 3 }, { 4, 5, 6 } }; // new int도 그냥 생략해도 자동으로 입력이 된다
        //배열의 길이
        Debug.Log($"배열의 길이 :  {intArray.Length}");

        //출력
        for(int i = 0; i <intArray.GetLength(0); i++)
        {
            Debug.Log("=================");
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                Debug.Log(intArray[i,j]);
            }
            Debug.Log("=================");
        }

    }

   
}
