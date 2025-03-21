using PrivatePublic;
using UnityEditor;
using UnityEngine;
namespace Delegate
{
    public class DelegateNote : MonoBehaviour
    {
        //집에 가기 : 직진 -> 우회전 -> 직진 -> 좌회전 -> 우리집

        //대리자 선언 - 반환값도 없고, 매개변수 없다
        delegate void GoHome();
        delegate void Say();
        Say say3;

        //Delegate 변수 선언하고 메서드 등록
        GoHome go;

        //Action 형식을 통해 대리자 객체 생성
        //Action Func 
        System.Action driver;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //직접 운전 : 직진 -> 우회전 ->직진 -> 좌회전 -> 우리집
            CarDriver.GoForward();
            CarDriver.GeRight();
            CarDriver.GoForward();
            CarDriver.GeLeft();

            Debug.Log("==========================");

            //대리자 변수에 메서드 등록
            go = new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GeRight);
            go += new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GeLeft);
            go += new GoHome(CarDriver.GoForward); //메서드 등록
            go -= new GoHome(CarDriver.GoForward); // 메서드 취소
            go();
            Debug.Log("============================");

            //대리자 선언 및 메서드 등록
            CarDriver card = new CarDriver();
            Say say = card.Hello;
            say += card.Hi;
            say.Invoke();
            Debug.Log("============================");

            Insa insa = new Insa();
            //대리자 선언 및 메서드 등록
            Say say2 = insa.Bye;
            say2 += insa.Bye;
            say2 += card.Hi;
            say2.Invoke();
            Debug.Log("============================");

            //메서드 등록 및 호출 : say3 == null
            //if(say3 != null)
            //{
            //    Debug.Log("=====================");
            //    say3.Invoke();
            //}
            say3?.Invoke();
            Debug.Log("============================");
            driver = CarDriver.GoForward;
            driver += CarDriver.GeRight;
            driver += () => Debug.Log("후진");
            driver += delegate () { Debug.Log("주차"); };
            driver?.Invoke();

        }


    }
}