using UnityEngine;

//1 ,2 ,3, 4, 5
//5, 4, 3, 2, 1
public class ForCountDownDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1���� 5���� 1�� �����ϴ� ī��Ʈ �ٿ�

        for (int i = 1; i < 6; i++) 
        {
            Debug.Log($"���� Countdown : {i}");

        }
        Debug.Log("------------------------------------------");
        for (int i = 5; i >0 ; i--)
        {
            Debug.Log($"���� Countdown : {i}");

        }

        //[2] 5���� 1���� �����ϴ� ī��Ʈ �ٿ�
    }



}
