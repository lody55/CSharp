using UnityEngine;
using PrivatePublic; // Categorii가 정의된 네임스페이스 추가!

public class PublicField : MonoBehaviour
{
    void Start()
    {
        Categorii book = new Categorii(); // ✅ 정상 작동해야 함
        book.books = "책 이름";
        Debug.Log(book.books);
    }
}







