using UnityEngine;

public class Else : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //만약 score가 60이상이면 "합격" 출력
        // 아니면 " 불합격" 출력
        // score은 61점
        int score = 59;// [1]

        if (score >= 60)
        {

            Debug.Log("합격"); //[2]
        }
        else
        {
            Debug.Log("불합격"); //[3]

        }
        Debug.Log("종료"); //[4]




    }
    //score = 59; : [1] >> [3] >> [4]
    //score = 61; : [1] >> [2] >> [4]


}
