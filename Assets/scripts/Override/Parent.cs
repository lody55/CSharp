using UnityEngine;
namespace Override
{

    //부모 클래스
    public class Parent
    {
        public void Say() => Debug.Log("부모 안녕하세요");

        public void Run() => Debug.Log("부모 달린다");
        public virtual void Work() => Debug.Log("부모 걷다");

    }

    //자식 클래스
    public class Child : Parent
    {
        public new void  Say() => Debug.Log("자식 안녕하세요");
        
        public new void Run() => Debug.Log("자식 달린다");
        public override void Work() => Debug.Log("자식 걷다");
    }
}