using UnityEngine;

// Exception 클래스를 이용하여 예외내용 알아보기
public class ExceptionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int[] arr = new int[2];
            arr[3] = 10;
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
        string inputNumber = "3.14f";
        int number = 0;

        try
        {
            number = System.Convert.ToInt32(inputNumber);
            Debug.Log($"입력한값은{number}");
        }
        catch(System.FormatException fe)
        {
            Debug.Log(fe.Message);
            Debug.Log($"{number}는 정수여야 합니다");
        }
        
    }


}
