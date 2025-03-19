using UnityEngine;
namespace Constructor
{

    public class ReadOnlyNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //WithService 클래스의 객체 생성
            WithService file = new WithService("[1] 파일로그"); // 생성자여서 가능
            file.Run();

            WithService db = new WithService("[2] db로그"); // 생성자라 가능
            db.Run();
        }


    }
}