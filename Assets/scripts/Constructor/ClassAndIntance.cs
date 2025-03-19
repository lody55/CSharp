using UnityEngine;
namespace Constructor
{

    public class ClassAndIntance : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog 클래스의 객체 생성
            Dog happy = new Dog("해피");

            Debug.Log(happy.Cry());

            Dog worry = new Dog("워리");
            Debug.Log(worry.Cry());
        }


    }
}