using UnityEngine;

public class ForIncrement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //증감식
        // 0부터 10까지 카운팅 2씩 증가하면서 출력
        // 0, 2, 4, 6, 8, 10 출력
        for(int i= 0; i < 11; i=i+2)//(증감식에 식이 들어가도 됨) 
        {
            Debug.Log(i);
        }
    }

  
}
