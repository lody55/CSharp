//[1] 네임스페이스 선언부
using UnityEngine; // 현재 (FileNew)클래스 파일에서 unityengine 네임스페이스를 사용하겠다

//[2] 클래스 선언부 : 클래스의 이름은 FileNew
public class FileNew : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // [3] (start)메서드(함수) 선언 : 프로그램을 시작할 때 1번만 실행
    void Start()
    {
        //[5] 명령문 : 콘솔창 출력문 
        Debug.Log("hello world!!!!");
    }

    // Update is called once per frame
    // [4] (update) 메서드(함수) 선언 : 프로그램 시작 후에 매 프레임마다 실행
    void Update()
    {
        
    }
}
