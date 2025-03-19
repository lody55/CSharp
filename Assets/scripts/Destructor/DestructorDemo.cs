using Bar;
using UnityEngine;
namespace Constructor
{
    public class DestructorDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Car 클래스의 객체(하얀,파란,빨간)를 생성하고 달리기 구현
            Car whiteCar = new Car();
            whiteCar.Run();

            //whiteCar 폐차 : GC에서 알아서 소멸

            Car bluecar = new Car("파란");
            bluecar.Run();

            Car redcar = new Car("빨간");
            redcar.Run();
        }
        ~DestructorDemo()
        {
            Debug.Log("[3] 소멸");
        }

    }
}