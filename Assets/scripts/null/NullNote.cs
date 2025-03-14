using UnityEngine;

//null 연산자 : ??(null 병합 연산자), ?.(null 조건부 연산자)
public class NullNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //??(null 병합 연산자)
        string nullvalue = null;
        string message = "";
        
        //message 변수 초기화
        //if(nullvalue == null)
        //{
        //    message = "null 이면 새로운 값으로 초기화";
        //}

        message = nullvalue ?? "null 이면 새로운 값으로 초기화";
        Debug.Log(message);

        //?.(null 조건부 연산자)
     

        int? len;
        string msg = null;
        len = msg?.Length;
        Debug.Log(len);  // null 출력

        msg = "안녕하세요";
        len = msg?.Length; // msg가 변경된 후 다시 길이를 저장
        Debug.Log(len);  // 5 출력

        //if(msg != null)
        //{
        //    len = msg.Length;
        //}
        //else
        //{
        //    len = null;
        //}
        //msg가 null이면 null을 반환, null이 아니면 ?.뒤에있는 값을 반환




        //
    }

}
