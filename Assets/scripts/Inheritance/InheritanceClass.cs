using UnityEngine;
namespace Inheritance04
{
    public class InheritanceClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ParentClass 클래스의 객체 생성
            ParentClass parentClass = new ParentClass();
            //parentClass.PrintMessage();
            Debug.Log(parentClass.ToString());

            //ChildClass 클래스의 객체 생성
            ChildClass child = new ChildClass();
            child.PrintMessage2();
            //child.PrintMessage();

            //SubClass 클래스의 객체 생성
            SubClass sub = new SubClass();
            //sub.PrintLog(); >> protected 보호수준 때문에 안된다
            sub.PrintDebug(); // 자식클래스를 통해 직접접근은 안되지만 간접으로 접근해서 가져올수 있다
        }


    }
}

/*
 접근제한자 :public , private, protected

protected : 상속받은 자식 클래스 코드블록{}안에서만 접근가능, 사용 가능
 
public : 외부 클래스에서 접근, 사용가능
private : 외부 클래스에서 접근, 불가능
protected : 외부 클래스에서 접근 불가능 단, 상속받은 자식 클래스의 코드블록 안에서 사용 가능
 */