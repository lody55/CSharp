using UnityEngine;
namespace Inheritance
{
    //자식 클래스
    //부모 클래스 선언
    // class 자식클래스 이름 : 부모 클래스 이름
    public class Child : Parent
    {
        public void Bar()
        {
            Debug.Log("자식 클래스 ");
        }
    }
}