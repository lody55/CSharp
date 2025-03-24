using UnityEngine;
namespace Interface
{
    public class InterfaceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog 클래스 객체 생성
            Dog dog = new Dog();
            dog.Eat();  
            dog.Cry();  //IAnimal,IDog 두 인터페이스 상속받아 Eat,Cry 구현
        }


    }
}