using UnityEngine;
namespace Inheritance09
{
    //추상 클래스(abstract) 선언 : 자신을 상속 받는 자식 클래스에서 지정한 (메서드)기능을 강제로 구현하도록 한다.
    // 추상 메서드 : 지정한 기능(메서드)
    //public abstract class void 추상메서드 이름();
    public abstract class GeneralManager 
    {
        //추상 메서드 : 메서드 구현 부분(코드블록, 본문)을 생략
        public abstract void SayTalk();
        
    }

    //Person 클래스는 추상클래스(GeneralManager)를 상속 받는 자식클래스 

    public class Person : GeneralManager
    {
        //상속 받은 추상 메서드 구현 부분
        //public override void 추상메서드이름
        public override void SayTalk()
        {
            Debug.Log("상속 받은 추상 메서드를 구현한다");
        }
    }
}
/*
 pub
 */