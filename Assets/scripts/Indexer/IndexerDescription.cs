using Indexer;
using UnityEngine;
namespace Indexer
{
    public class IndexerDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Catalog ca = new Catalog();
            Debug.Log(ca[0]); //객체이름[인덱스] 형태로 사용
            Debug.Log(ca[1]); //객체이름[인덱스] 형태로 사용
            Debug.Log(ca[2]); //객체이름[인덱스] 형태로 사용
            Debug.Log(ca[99]); //객체이름[인덱스] 형태로 사용
        }


    }
}
/*
 Indexer(인덱서) 
- 클래스의 객체를 배열처럼 []를 사용할 수 있도록 해주는 구문 ( 배열은아니지만 배열처럼 사용)
- 객체이름[0] , 객체이름[1]
- 클래스의 필드(배열,컬렉션)의 값을 인덱서로 호출해서 사용(읽기,쓰기)이 가능
-
 인덱서 형식
 Class Car
 Car cars = new Car(3); 매개변수 집어넣어서 생성 (안넣어도 됨, 보통 넣어서 사용)
 cars[0] = "a" 
 cars[1] = "b"
 cars[2] = "c"
 
 */