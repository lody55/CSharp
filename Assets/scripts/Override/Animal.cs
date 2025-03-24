using UnityEngine;
using UnityEngine.Rendering.Universal;
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

    // 자식 클래스
    public class Cat : Animal
    {
        public override void Eat()
        {
            //부모 메서드에서 구현된 내용을 모두 실행하고 
            base.Eat();
            //새로 추가된 내용을 실행하라
            Debug.Log("고양이가 밥을 먹는다");
        }
    }
}