using UnityEngine;

namespace Method
{
    public class MethodPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog 클래스의 객체 생성
            Dog cat = new Dog();
            cat.Eat();      //[1]public 메서드 호출 가능
            cat.weight = 30; //[2] public 필드 접근가능


        }


    }
}