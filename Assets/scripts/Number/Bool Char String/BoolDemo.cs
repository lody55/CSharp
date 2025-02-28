using UnityEngine;

//bool (불형) : 논리자료형 , (불타입) , 참(true) or 거짓(false) 값만 저장
public class BoolDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] bool 변수 선언하고 초기화
        bool bin = true;
        Debug.Log("bin : " + bin);
        bool isout = false;

        Debug.Log("isout : " + isout);
    }

}
