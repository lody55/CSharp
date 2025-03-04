using UnityEngine;

public class InPrase : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string strnumber = "1234";

        int number1 = System.Convert.ToInt32(strnumber);

        Debug.Log($"{number1}-{number1.GetType()}");

        int number2 = int.Parse(strnumber);

        Debug.Log($"{number2}-{number2.GetType()} ");

        int number3 = System.Int32.Parse(strnumber);
        Debug.Log($"{number3}-{number3.GetType()}");



        
    }

   
}
