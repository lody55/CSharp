using UnityEngine;
namespace Inheritance04
{
    //자식 클래스
    public class SubClass : BaseClass // :(콜론)으로 부모 클래스를 자식이 지정한다
    {
        public void PrintDebug()
        {
            base.PrintLog(); //base 키워드로 부모 멤버에 접근한다
        }
    }
}