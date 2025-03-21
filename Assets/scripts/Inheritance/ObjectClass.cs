using Inheritance;
using UnityEngine;
namespace Inheritance
{
    public class ObjectClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //static 메서드는 클래스의 객체를 생성하지 않고 호출
            //static 메서드 호출방법 : 클래스 이름. 메서드이름
            ChildClass.Hello();
            //ChildClass.Hi();

            //ParentClass 클래스의 객체생성
            ParentClass parent = new ParentClass();
            Debug.Log(parent.ToString());

            //ChildClass  클래스의 객체 생성
            ChildClass child = new ChildClass();
            Debug.Log(child.ToString());
        }

    }
}