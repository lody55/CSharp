using UnityEngine;
namespace Method
{
    //[2]참조 전달 방법 (ref int num)
    public class ParameterRef : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int number = 10;
            Debug.Log($"[1] : {number}");

            PrintNumbers(ref number);

            Debug.Log($"[3] : {number}");


        }

        //정수형 ref number를 매개변수로 입력 받아 출력하는 함수
        void PrintNumbers(ref int number)
        {
            number = 30;
            Debug.Log($"[2] : {number}");
        }
    }
}