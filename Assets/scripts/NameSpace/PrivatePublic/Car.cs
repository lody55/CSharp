using UnityEngine;

namespace PrivatePublic
{
    public class Car
    {
        //필드 선언(전역변수 , 멤버변수) - public,private
        public string name;  //이름 
        private int age; //나이

        string address; //접근제한자가 생략되어 있으면 private

        //멤버 메서드 - public , private
        public void Hi()
        {
            Debug.Log("안녕하세요");
        }

        private void Bye()
        {
            Debug.Log("안녕히 계세요");
        }
    }
}