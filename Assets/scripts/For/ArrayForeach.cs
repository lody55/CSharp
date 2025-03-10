using UnityEngine;

//Foreach : 배열에 저장된 값들을 순서대로 모두 가져와서 사용
public class ArrayForeach : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //배열 요소들의 값을 모두 가져와서 총 합을 구하는 프로그램 구현
        float[] arr = {10.5f,20.1f,30.3f};
        float sum = 0f;

        //for(int i = 0; i<3; i++)
        //{
        //    sum = sum + arr[i];
        //}
        //배열은 반복문과 같이 쓰인다
        
        foreach(float f in arr) // 저장할 값이 없을 때 반복문 종료
        {
            //반복 실행문
            sum = sum + f;

        }

        Debug.Log($"총합은 {sum}");
    }

    
 
}
/*
 Foreach문 : 배열에 저장된 값들을 순서대로 모두 가져와서 사용
 배열의 데이터를 처음부터 끝까지 가져오고 더이상 가져올 데이터가 없을 때 반복문 종료 

 foreach(배열의 데이터 타입 변수 이름 in 배열변수 이름)
 {
       //반복 실행문
 }
 
 */