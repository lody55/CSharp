using UnityEngine;
namespace Constructor
{
    public class ConstructorForwarding : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Money 클래스 객체 생성
            Money basic = new Money();

            //매개 변수가 있는 생성자 호출
            Money basic2 = new Money(50000);
        }

    }
}