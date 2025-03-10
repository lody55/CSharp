using UnityEngine;

//2차원 배열 : 행과 열로 이루어진 배열

public class ArraytTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]배열 선언 ,2차원 배열
        int[,] intArray;


        //[2]배열 요소 수(크기) 생성
        intArray = new int[2,3];


        //[3]배열 초기화
        //0번행
        intArray[0, 0] = 1;
        intArray[0, 1] = 2;
        intArray[0, 2] = 3;
       
        //1번행
        intArray[1, 0] = 4;
        intArray[1, 1] = 5;
        intArray[1, 2] = 6;

        



        //[4]배열 사용
        for (int i = 0; i < 2; i++)
        {
            for(int y = 0; y < 3; y++)
            {
                Debug.Log(intArray[i, y]);
            }
            
        }
        
    }

   
}
