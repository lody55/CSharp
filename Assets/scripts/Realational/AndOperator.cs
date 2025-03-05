using UnityEngine;

//AndOperator(And 연산자) :&&(And 연산) 둘다 참일때만 참
//결과 : true , false
public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 둘다 참일때만 참
        Debug.Log(true && true); // >>>>true

        //[2] 둘중 하나라도 거짓이라면 거짓
        Debug.Log(true && false); // >>>>>false

        //[3] 둘다 거짓일 때
        Debug.Log(false && false); //>>>>>>>false
        

    }

  
}
