using UnityEngine;


//문자열 묶는 방법(문자열 꾸미기)
public class StringDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var displayName = "";
        var fistname = "길동";
        var lastname = "홍";

        //output : "이름 : 홍길동"

        //[1] string 더하기(+) 연산자 사용
        displayName = "이름 : " + lastname + fistname;

        Debug.Log(displayName);

        //[2] string.Format() 메서드 사용
        displayName = string.Format("이름 :{0}{1}", lastname, fistname);
        Debug.Log(displayName);
    }

  
}
