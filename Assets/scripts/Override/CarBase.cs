using UnityEngine;
namespace Override
{
    public enum CarType
    {
        전기,
        내연기관
    }
   
    //부모 클래스 - 추상 클래스(객체 생성 불가)
    public abstract class CarBase
    {
        public abstract void Left();    //추상 메서드 (상속받은 클래스 강제로 구현), 본문(구현내용) 없음

        //접근 제한자 public - 자식클래스와 외부 모든 클래스에 공개, 접근 가능
        public void Back() => Debug.Log("후진");

        //접근 제한자 protected - 자식클래스에서만 접근, 사용 가능
        //접근 제한자 private - 외부 모든 클래스에ㅔ서 접근 불가능 , 선언한 클래스 코드블록 안에서만 사용가능
        protected string LeftMessage { get; private set; } = "좌회전한다";

    }
    //자식 클래스 
    public class Car : CarBase
    {
        //모든 자동차에 공통적으로 있는 속성
        public CarType Style { get; private set; }
        
        //생성자 - 매개변수를 입력받아 CarType 설정(초기화)
        public Car(CarType Ctype)
        {
            //this 키워드를 이용해서 자신(객체)의 멤버에 접근(생략 가능)
            this.Style = Ctype;
        }
        
        public void Go()
        {
            Debug.Log("달린다");
        }

        //부모의 추상 메서드를 실제 코드 구현, 
        public override void Left()
        {
            //base키워드를 통해 부모(객체)의 멤버에 접근(public , protected)
            Debug.Log(base.LeftMessage);
        }
    }

    //손자 클래스
    public class HyunDai : Car
    {
        public HyunDai() : this(CarType.내연기관)
        {
            
        }
        public HyunDai(CarType carType) : base(carType)
        {
            
        }
    }
    public class Tesla : Car
    {
        public Tesla() : this(CarType.전기)
        {

        }
        public Tesla(CarType carType) : base(carType) { }
    }

    //sealed (봉인) 키워드 통해서 봉인 클래스 설정 - 더이상 상속이 불가
    public sealed class Mirea : Car
    {
        public Mirea() : this(CarType.전기)
        {

        }
        public Mirea(CarType ctype) : base(ctype) { }
        public new void Go() => Debug.Log("난다");
    }
    
}