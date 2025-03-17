using UnityEngine;

namespace PrivatePublic
{
    public class PublicAndPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1]Car 클래스의 객체(인스턴스) 생성
            Car mycar = new Car();

            //[2]Car 클래스의 객체를 통해 public한 필드에 접근해서 사용
            mycar.name = "홍길동";
            Debug.Log(mycar.name);

            //[3]Car 클래스의 객체를  통해 private한 필드에 접근해서 사용(X)
            // mycar.age = 21;
            // mycar.address = "수원";

            //[2]Car 클래스의 객체를 통해 public한 필드에 접근해서 사용
            mycar.Hi();

            //[3]Car 클래스의 객체를  통해 private한 필드에 접근해서 사용(X)
            //mycar.Bye();  
        }


    }
}