using UnityEngine;

//RealationalOperator(관계형 연산자, 비교 연산자)
// < (작음) , <= (작거나 같음) , >(큼) , >=(크거나 같음), ==(같음), !=(다름)  ------비교연산자
// 결과 : true(참) , false(거짓)
public class RealationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;
        Debug.Log(x < y); //x(3)가 y(5)보다 작으냐?  >>>> true
        Debug.Log(x <= y); //true
        Debug.Log(x >y); // false
        Debug.Log(x >= y); //false
        Debug.Log(x == y); //false
        Debug.Log(x != y); //true

        Debug.Log("AAA" == "aaa");// false


    }

}
