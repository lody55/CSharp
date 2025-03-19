using UnityEngine;
namespace Method
{

    //OptionalParameter(선택적 매개변수) - 사용해도 되고, 생략해도 되는 매개변수

    public class ParameterOptional : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(Add(5 ));
            Debug.Log(Add(5,4));
        }

        // 선택적 매개변수 : b 선언과 동시에 초기화
        //b변수는 사용해도 되고 생략해도 된다 생략하면 b의 값은 1이 된다
        int Add(int a , int b=1)
        {
            return a + b;
        }

    }
}