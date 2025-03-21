using UnityEngine;
namespace Indexer
{
    public class IndexerDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Person 클래스의 객체 생성
            Person per = new Person();
            per[0] = "홍길동";
            Debug.Log(per[0]);  // 홍길동

            per[1] = "백두산";
            Debug.Log(per[1]);  // 백두산

            Debug.Log(per[0]);  // 백두산
        }

    }
}