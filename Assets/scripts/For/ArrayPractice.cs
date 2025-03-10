using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int[,] intArray;

        //intArray = new int[3, 3];

        //intArray[0, 0] = 1;
        //intArray[0, 1] = 0;
        //intArray[0, 2] = 0;
        //intArray[1, 0] = 0;
        //intArray[1, 1] = 1;
        //intArray[1, 2] = 0;
        //intArray[2, 0] = 0;
        //intArray[2, 1] = 0;
        //intArray[2, 2] = 1;

        //for(int i = 0; i < 3;i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Debug.Log($"arr[{i},{j}] : {intArray[i,j]}");
        //    }
        //}

        // 3행 3열의 2차원 배열을 만듦
        int[,] arr = new int[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

        //값 초기화
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                {
                    arr[i, j] = 1;
                }
                else //행과 열의 인덱스가 틀리면 0
                {
                    arr[i, j] = 0;
                }

            }
            for (int y = 0; y < 3; y++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Debug.Log($"arr[{y},{j}] :{arr[y, j]}");
                }

            }
        }

    }

  
}
/*
 [Q]
 3행3열의 2차원 배열을 만들고
 배열의 값을 초기화 하는데 
 행과 열의 인덱스가 같으면 1, 행과 열의 인덱스가 틀리면 0으로 저장하세요
 저장하는 방법을 이중 for문 이용하세요

[output]
 1, 0, 0
 0, 1, 0
 0, 0, 1
 [출력]
 arr[0,0] : 1
 arr[1,0] : 0
 .
 .
 .
 arr[2,2] : 1

 */