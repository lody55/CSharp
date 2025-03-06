using UnityEngine;

//1 ,2 ,3, 4, 5
//5, 4, 3, 2, 1
public class ForCountDownDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1부터 5까지 1씩 증가하는 카운트 다운

        for (int i = 1; i < 6; i++) 
        {
            Debug.Log($"증가 Countdown : {i}");

        }
        Debug.Log("------------------------------------------");
        for (int i = 5; i >0 ; i--)
        {
            Debug.Log($"감소 Countdown : {i}");

        }

        //[2] 5부터 1까지 감소하는 카운트 다운
    }



}
