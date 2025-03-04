using UnityEngine;

// UnaryOperator (단항연산자) : +,-,
public class UnaryOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int형 변수 value선언하고 0으로 초기화
        int value = 0;

        value = 8; //value라는 변수에 8 값을 저장 출력하면 > 8
        //[1]
        value = +value;
        Debug.Log(value);
        //[2]
        value = -8; //value 변수에 -8 저장
        value = +value;
        Debug.Log(value);
        //[3]

        value = 8;
        value = -value;
        Debug.Log(value);

        //[4]
        value = -8;
        value = -value;
        Debug.Log(value);
    }


}
