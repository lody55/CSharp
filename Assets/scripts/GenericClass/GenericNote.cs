using UnityEngine;
using System.Collections.Generic;
namespace GenericClass
{
    public class GenericNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Cup 클래스의 객체 생성
            //[1] T에 string을 지정하여 문자열을 저장하는 속석 생성
            Cup<string> cup = new Cup<string>();
            cup.Contents = "문자열";

            //[2] T에 int를 지정하여 정수형 숫자를 저장하는 속성 생성
            Cup<int> number = new Cup<int>();
            number.Contents = 1234;

            Debug.Log($"{cup.Contents} , {number.Contents}");

            //[3] T에 Water(사용자정의 데이터 형식)를 지정하면 물을 저장하는 속성 생성
            Cup<Water> water = new Cup<Water>();
            water.Contents = new Water();
            Debug.Log(water.Contents.ToString());

            Cup<Coffee> Coffee = new Cup<Coffee>();
            Coffee.Contents = new Coffee();
            Debug.Log(Coffee.Contents.ToString());
        }


    }
}