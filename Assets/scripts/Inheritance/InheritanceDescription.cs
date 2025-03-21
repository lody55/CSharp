using Inheritance;
using UnityEngine;

public class InheritanceDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Child 클래스의 객체 생성
        Child child = new Child();
        child.Foo();    //부모 클래스의 메서드를 호출
        child.Bar();    //자식 클래스의 메서드 호출
    }


}

/*
 Inheritance(상속)
- 부모 클래스가 자신의 기능을 자식 클래스에게 물려주어서 사용하도록 해준다
- 부모클래스 : Base클래스, 슈퍼클래스 , 기본 클래스라고도 불린다 
- 자식 클래스를 여러개 가질수 있다
- 자식 클래스들의 공통 기능을 모아놓은 클래스


- 자식클래스 : Sub(서브) 클래스  부모클래스의 기능을 물려 받는다

- 손자클래스 : 자식의 자식클래스 - 부모 + 자식클래스의 기능을 모두 물려받는다

 */