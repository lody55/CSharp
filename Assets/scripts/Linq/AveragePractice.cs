using System.Linq;
using System.Runtime.InteropServices;
using Unity.Android.Gradle.Manifest;
using Unity.VisualScripting;
using UnityEngine;

public class AveragePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] number = { 90, 65, 78, 50, 95 };

       
        double average = 0;
        int sum = 0;
        int count = 0;
        for (int i = 0; i< number.Length;i++)
        {
            if (number[i] >=70 && number[i] <=95 )
            {
                sum = sum + number[i];
                    count++;
            }

        }
        if(count >0)
        {
            average = sum / (double)count;
        }

        Debug.Log($"평균점수 : {average:0.00}");
        double numbers = number.Where(n => n >= 70 && n <= 95).Average();
        Debug.Log($"평균점수 : {numbers:#.##}");
        
       
    }


}
    /*
[Q]
    입력 데이터 {90, 65 , 78 , 50 , 95}
국어점수 중 70점 이상이고 95점 이하인 점수들의 평균을 구하라

[output]
평균점수: average
 */