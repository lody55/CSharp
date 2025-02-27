using UnityEngine;

// Log : 프로그램의 결과를 콘솔창에 출력
public class LogDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 
        Debug.Log("hello world!!!");
        //[2]
        UnityEngine.Debug.Log("hello unity!!!");
        //[3]
        Debug.Log("결과는:" + 5);
        Debug.Log("결과는:" + (5+10));
        Debug.Log("결과는:" + 5+10);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
