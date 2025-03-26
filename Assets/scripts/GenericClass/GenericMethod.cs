using UnityEngine;
using System.Collections.Generic;
namespace GenericClass
{
    
    public class GenericMethod : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Hello 클래스 객체 생성
            Hello<int> hello = new Hello<int>(1234);
            hello.Say(hello.GetMessage());

            Hello<string> hi = new Hello<string>("안녕하세요");
            hi.Say(hi.GetMessage());
        }


    }
}