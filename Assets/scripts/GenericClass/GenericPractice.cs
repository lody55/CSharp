using UnityEngine;
using System.Collections.Generic;
using System;

namespace GenericClass
{

    public class GenericPractice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //MyList 제네릭클래스의 객체 생성
            MyList<int> numbers = new MyList<int>(3);
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            for(int i = 0; i < numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }
            MyList<string> names = new MyList<string>(3);
            names[0] = "안녕하세요";
            names[1] = "반갑습니다";
            names[2] = "힘내세요";
            
            foreach (var s in names)
            {
                Debug.Log(s);
            }
        }


    }
}