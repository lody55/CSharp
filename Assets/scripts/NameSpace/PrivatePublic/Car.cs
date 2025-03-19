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

        //private한 필드(age)를 외부에 공개하고자 할 때 public한 메서드를 이용한다
        //매개변수로 나이를 입력받아 age에 저장하는 함수
        public void SetAge(int iAge)
        {
            age = iAge;
            
        }
        //age를 반환하는 함수 
        public int GetAge()
        {
            return age;
        }
    }
}