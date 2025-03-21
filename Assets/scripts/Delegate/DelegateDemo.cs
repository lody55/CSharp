using UnityEngine;
namespace Delegate
{
    public class DelegateDemo : MonoBehaviour
    {
        //[1] Delegate 생성 - double형 반환, 매개변수 int
        //delegate double (대리자 이름) (int)
        delegate double GetcircleArea(int r);

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[2] Delegate변수 선언하고 메서드 등록
            GetcircleArea area = GetArea;

            //[3] Delegate변수 사용 : 변수를 통해 메서드 호출
            Debug.Log(area(10));
            Debug.Log(area.Invoke(10));

        }

        //매개변수로 원의 반지름을 입력 받아 원의 면적을 구하는 메서드
        double GetArea(int r)
        {
            return 3.14 * r * r;
        }

    }
}