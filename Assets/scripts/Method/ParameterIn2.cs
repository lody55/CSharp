using UnityEngine;
namespace Method
{

    struct point
    {
        public int x;
        public int y;
    }
    //[1] 값 전달 방법 : 구조체
    public class ParameterIn2 : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            point point;
            point.x = 10;
            point.y = 0;
            Debug.Log($"[1]point.x :{point.x}");
            PrintPoint(point);

            Debug.Log($"[3]point.x : {point.x}");
        }

        //매개변수로 구조체를 입력받아 구조체에 포함되어 있는 변수를 출력하는 메서드

        void PrintPoint(point point)
        {
            point.x = 20;
            point.y = 0;
            Debug.Log($"[2]point.x :{point.x}");

        }
    }
}