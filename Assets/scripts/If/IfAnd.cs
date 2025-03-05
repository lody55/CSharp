using UnityEngine;

//&&, ||
public class IfAnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 1234;
        int age = 20;
        string name = "홍길동";
        // 조건식 2개 : number가 1234와 같냐? , number가 1000이상이냐?
        // 2가지 조건을 모두 만족하면 맞습니다 출력
        if(number == 1234 && number >= 1000)
        {
            Debug.Log("맞습니다");

        }

        // 조건식이 1234와 같냐? , 1000이하냐?
        // 2가지 조건 중 하나라도 만족하면 출력(실행문 실행)
        /*if (number == 1234 || number <= 1000)
        {
            Debug.Log("하나라도 참이면 참");




        }
       */
        if (name == "홍길동" && age == 20)
            
        {
            Debug.Log($"이름은{name}, 나이는 {age}");

        
        }
        
    }
    
   
}
