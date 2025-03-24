using UnityEngine;
namespace Override
{
    public class MethodOverrideDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Base 클래스의 객체 생성
            Base parent = new Base();
            parent.Work();

            //Sub 클래스의 객체 생성
            Sub sub = new Sub();
            sub.Work();

            //Grand Sub 클래스의 객체 생성
            GrandSub grand = new GrandSub();
            grand.Work();
            grand.Play();
        }


    }
}