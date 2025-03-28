using UnityEngine;

//
public class StringEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정의
        string userName = "RedPlus";
        string inputName = "redPlus";

        //[2-1] 결과 : 연산자(==)를 이용
        if (userName.ToLower() == inputName.ToLower())
        {
            Debug.Log("[1] 같습니다");

        }
        //[2-2] 결과 : string.Equal() 메서드 사용
        if (string.Equals(userName,inputName,System.StringComparison.InvariantCultureIgnoreCase))
        {
            Debug.Log("[2] 같습니다");
        }
    }

   
}
