using UnityEngine;

namespace Constructor
{
    public class Car
    {
        private string color;

        // 기본 생성자
        public Car()
        {
            color = "하얀";
            Debug.Log($"{color}색 자동차를 만듭니다");
        }

        // 매개변수가 있는 생성자
        public Car(string _color)
        {
            this.color = _color;
            Debug.Log($"{_color}색 자동차를 만듭니다");
        }

        // 🚗 자동차가 달리는 동작을 수행하는 메서드
        public void Run()
        {
            Debug.Log($"{color}색 자동차가 달립니다! 🏎️💨");
        }
    }
}