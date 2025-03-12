using UnityEngine;

//As 연산자 : ~ 형식 변환하기, 지정된 형식으로 변환이 가능하면 변환, 변환이 불가하면 null을 반환 합니다. 
public class AsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        object s = "반갑습니다";
        string r1 = s as string;
        Debug.Log(r1);

        object i = 1234;
        string r2 = i as string;
        if (r2 == null)
        {
            Debug.Log("null 입니다");
        }
        object i2 = 5678;
        if(i2 is string)
        {
            string r3 = i2 as string;
            Debug.Log($"{r3} ");
        }
        else
        {
            Debug.Log("변환불가 합니다");
        }
    
    }

    
}
