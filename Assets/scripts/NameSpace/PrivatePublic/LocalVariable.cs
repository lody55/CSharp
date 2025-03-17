using UnityEngine;

namespace PrivatePublic
{


    public class LocalVariable : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //LocalVariable(지역변수) 선언
            int i = 1234;
            int j = 4567;

            

            //지역변수 사용
            Debug.Log(i + j);
        }


    }
}

/*
 Field (필드, 전역변수, 멤버 변수) : 클래스의 부품 역할을 하는 클래스 내부 상태 값을 저장하는 그릇(변수)
- 클래스의 속성
- 필드는 액세스 한정자를 지정합니다
- 필드는 (대부분) 필드 선언부에서 선언하고 또 초기화 한다

Field (필드, 전역변수, 멤버 변수) 네이밍
- 변수의 맨 앞글자의 알파벳은 소문자로 시작한다
- 변수 중간에 단어로 연결할때 단어 시작은 대문자로 사용한다
- m_name
- 상수 , 읽기전용 변수는 첫 알파벳은 대문자로 시작한다


<액세스 한정자> - 접근 제한자 - 기본 엑세스 한정자는 private
 - public : 누구든지 접근 가능하다
 - private : 해당(현재)클래스 안에서만 접근이 가능
 - protected : 해당(현재)클래스 안에서만 접근이 가능, 상속 받은 자식 클래스에서 접근 가능
 - internal : 해당 프로젝트 내에서 접근이 가능하다
 - protected internal
 */