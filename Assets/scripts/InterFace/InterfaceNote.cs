using UnityEngine;
namespace Interface
{

    public class InterfaceNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //HyunDaiCar 클래스 객체 생성
            HyunDaiCar goodcar = new HyunDaiCar(new Good());
            goodcar.Run();

            HyunDaiCar badcar = new HyunDaiCar(new Bad());
            badcar.Run();
        }

    }
}