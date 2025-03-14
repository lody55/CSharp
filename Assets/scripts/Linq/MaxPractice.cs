using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class MaxPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] number = { -2, -5, -3, -7, -1 };

        //최대값 저장하는 변수
        //max의 초기화 값 : max의 데이터 타입이 가지는 값 중 가장 작은 값으로 초기화
        int max = int.MinValue;

        for(int i = 0; i<number.Length;i++)
        {
            if (number[i] > max)
            {
                max = number[i];
            }
        }
       // max = number.Max();

        Debug.Log($"최대값 : {max}");
    }


}
/*
 [Q]
 입력데이터 {-2, -5, -3, -7, -1}
 입력 데이터중에서 최댓값을 구하세요
 
[output]
최대값 : -1

 */