using UnityEngine;

namespace PrivatePublic
{

    public class Person
    {
        //[1] 변수 형식의 필드
        private string name = "홍길동";
        //[2] 상수 형식의 필드
        private const int Age = 21;
        //[3] 읽기전용 형식의 필드
        private readonly string NickName = "도깨비";
        //[4]배열 형식의 필드
        private string[] address = { "서울", "수원", "인천" };
        //[5]object 형식의 필드
        private object obj = System.DateTime.Now.ToShortTimeString();
        
        //public 메서드
        public void ShowProfile()
        {
            Debug.Log($"이름 : {name}, 나이 :{Age}, 별명 : {NickName}");
        }
    }
}