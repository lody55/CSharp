using UnityEngine;

namespace PrivatePublic
{
    public class Say
    {
        //[1] 필드(Field), 멤버변수) 선언
        string message = "안녕하세요";

        //[2] 메서드(함수) 선언
        public void Hi()
        {
            this.message = " 반값습니다";
            Debug.Log(this.message);
        }
    }
}