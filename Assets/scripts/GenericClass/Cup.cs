using UnityEngine;
using System.Collections.Generic;
namespace GenericClass
{
    //Cup<T> : 컵오브티 , 전용 컵

    public class Water
    {

    }
    public class Coffee
    {

    }

    //제네릭 클래스만들기 - 클래스 이름<T>
    public class Cup<T>
    {
        public T Contents { get; set; }


        //매개변수로 입력받은 T형식 데이터를 출력하라
        public void PrintData(T data)
        {
            Debug.Log($"{data}");
        }
    }
}