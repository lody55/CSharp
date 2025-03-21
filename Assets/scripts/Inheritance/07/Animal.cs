using UnityEngine;
namespace Inheritance07
{
    //부모 클래스
    public class Animal
    {
        public void Eat() => Debug.Log("밥을 먹어요");
    }

    //자식 클래스 : Animal을 부모로 지정
    // sealed : Cat 클래스를 봉인(sealed) 클래스로 지정 , 최종 클래스가 되어 상속이 불가능
    // 최종 클래스가 되어 상속이 불가능, 나를 부모로 지정하지 못하도록 막는다
    public sealed class Cat : Animal
    {

    }

    //자식 클래스 : Cat 클래스를 부모로 지정
    //public class  MyCat : Cat
    //{
        //sealed클래스여서 상속을 받지 못한다. 부모클래스로 지정 불가능

    //}
}

