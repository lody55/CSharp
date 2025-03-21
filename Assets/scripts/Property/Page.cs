using UnityEngine;
namespace Property
{
    //읽기 전용 속성 만들기 - ()쓰기를 막는다
    public class Page
    {
       private string Message { get; set; } = "읽기 전용 속성";
    }
}