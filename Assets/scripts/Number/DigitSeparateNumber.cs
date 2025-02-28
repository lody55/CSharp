using UnityEngine;

// 1,000,000 > 편하게 하기위해 , 대신에  _ (언더스코어)씀
public class DigitSeparateNumbert : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 1_000_000; //int형 변수 num선언 후 1000000으로 초기화

        Debug.Log("num : " + num);

    }


}
