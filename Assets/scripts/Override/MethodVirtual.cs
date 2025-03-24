using UnityEngine;
namespace Override
{
    public class MethodVirtual : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //    //Animal 클래스의 객체 생성
            //    Animal animal = new Animal();
            //    animal.Eat();

            //    //Dog 클래스의 객체 생성
            //    Dog dog = new Dog();
            //    dog.Eat();

            //부모 클래스(Animal)의 변수에 자식 클래스(Dog)의 객체 생성
            //    Animal Dog2 = new Dog();
            //    Dog2.Eat();

            //    //Cat 클래스의 객체 생성
            //    Cat cat = new Cat();
            //    cat.Eat();


            //업캐스팅 : 클래스의 다형성
            //부모 클래스(Animal)의 변수에 자식 클래스(Dog)의 객체 생성
            Animal aDog = new Dog();
            aDog.Eat();

            Animal bCat = new Cat();
            bCat.Eat();
        }
    }
}