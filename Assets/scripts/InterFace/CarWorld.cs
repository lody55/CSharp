using UnityEngine;
namespace InterfaceTest
{
    public class CarWorld : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] Car클래스 객체 생성
            Car campingcar = new Car("캠핑카");
            campingcar.Run();

            //[2] 속성
            Car sportscar = new Car();
            sportscar.Name = "스포츠카";
            sportscar.Run();

            //[3] 인덱스
            Car cars = new Car(2);
            cars[0] = "1번 자동차";
            cars[1] = "2번 자동차";
            foreach(var s in cars)
            {
                Debug.Log(s);
            }
        }


    }
}
/*
- 객체지향 프로그램(OOP)
- 추상화
- 캡슐화
- 상속
- 다형성
 */