using UnityEngine;

namespace Property
{
    public class PropertyPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Page 클래스의 객체 생성
            Page page = new Page();
            //page.Message = "외부에서 쓰기 불가능";
            // Debug.Log(page.Message);

            User user = new User("홍길동");
            user.BirthYear = 2002;
            Debug.Log($"이름 :{user.Name}, 나이:{user.Age}");
        }


    }
}