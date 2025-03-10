using UnityEngine;

public class ArrayTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1차원 배열 선언, 요소 수(갯수)생성 , 값 초기화를 동시에 

        // int[] intArray = new int[3] { 1, 2, 3 };
        // [1 -2] 1차원 배열 선언 요소 수(갯수) 생성하면서 크기 생략, 값 초기화를 동시에
        //int[] intArray = new int[] { 1, 2, 3,4 };
        // [1 -2] 1차원 배열 선언, 값 초기화를 동시에
        int[] intArray = { 1, 2, 3, 4 };


        //[4] 배열의 사용
        for (int i = 0; i < 4; i++)
        {
            Debug.Log($"{i}번째 방의 값은 : {intArray[i]}");
        }

    }

}
