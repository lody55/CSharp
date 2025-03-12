using JetBrains.Annotations;
using UnityEngine;

//정적 메서드 호출, 인스턴스 메서드 호출 
public class MyFirstClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 정적(static) 메서드 호출 : StaticMethod호출 >>>> 호출 방법 : 클래스이름.메서드이름()
        ClassMember.StaticMethod();
        //ClassMember.InstanceMethod(); <- 안된다

        //[2] 인스턴스(Instance) 메서드 호출 - InstanceMethod() 호출
        // 호출방법 : 클래스의 객체(개체,Instance) 생성 - (클래스의 변수 선언)
        // new 키워드를 이용하여 새로운 객체를 생성
        //(클래스이름) 객체이름 = new 클래스이름();
        //(객체이름).메서드 이름
        ClassMember member = new ClassMember();
        member.InstanceMethod();
        //member.StaticMethod(); <-안된다


    }

 
}
