using UnityEngine;

//Collection(컬렉션) : 배열처럼 특정 항목의 집합을 관리하는 그릇
// 배열 , 리스트, 딕셔너리 등을 사용하여 관련 객체의 그룹을 만들고 관리한다
public class ArrayDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] colors = { "Red", "Green", "Blue" };

        Debug.Log($"배열의 요소수 갯수 : {colors.Length}");

        for(int i = 0; i<colors.Length; i++)
        {
            Debug.Log(colors[i]);
        }
    }

 
}
