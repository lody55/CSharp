using UnityEngine;

//LogicalOperator(논리 연산자) - && , ||, !
//OrOperator(Or 연산자) : ||하나라도 참이면 참
// 결과 : true , false
public class OrOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]둘다 참일 때
        Debug.Log(true || true); // >>>>>true

        //[2]둘 중에 하나가 참일 때
        Debug.Log(true || false); //>>>>>true

        //3[둘 다 거짓일 때
        Debug.Log(false || false); //>>>>>false

        
    }

 
}
