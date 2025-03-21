using UnityEngine;
namespace Override
{
    public class Animal
    {
        //virtual이 있는 메서드 : 가상 메서드
        public virtual void Eat() => Debug.Log("Animal Eat");
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Debug.Log("강아지가 밥을 먹는다");
        }
    }
}