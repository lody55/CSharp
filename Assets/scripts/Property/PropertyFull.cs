using UnityEngine;
namespace Property
{
    public class PropertyFull : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1]Person 클래스의 객체 생성
            Person person = new Person();

            //[2]메서드를 이용해서 name 값 저장 및 사용
            person.SetName("홍길동");
            Debug.Log(person.GetName());

            //[3] property(속성)을 이용하여 필드(name)값 저장 및 사용
            //Name 속성의 set기능 이용
            person.Name = "백두산";
            //Name 속성의 get기능 이용
            Debug.Log(person.Name);
        }


    }
}