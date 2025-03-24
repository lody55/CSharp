using Override;
using UnityEngine;

public class MethodOverrideNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Developer 클래스 객체 생성
        Developer developer = new Developer();
        Debug.Log(developer);

        WebDeveloper web = new WebDeveloper();
        Debug.Log(web);

        MobileDeveloper mobile = new MobileDeveloper();
        Debug.Log(mobile);
    }


}
