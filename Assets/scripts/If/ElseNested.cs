using UnityEngine;

//Else 중첩문 
public class ElseNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        char input = '1';

        //[1] input 'y'면 YES를 출력
        //[2] input 'n'면 NO를 출력
        //[3] input 그 외 나머지 이면 CANCLE 출력

        if (input == 'y')
        {
            Debug.Log("YES");


        }
        else
        {
            if (input =='n') 
            {
                Debug.Log("NO");


            }
            else 
            {
                Debug.Log("CANCLE");

            }
        }
    }



}
