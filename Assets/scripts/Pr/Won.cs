using Unity.VisualScripting;
using UnityEditor.Sprites;
using UnityEngine;

public class Won : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        A a = new A();
        a.Day();
        A.Sum(5, 6);
        
    }


}
public class A
{
    string[] days = { "일", "월", "화", "수", "목", "금", "토" };

    public void Day()
    {
        foreach(var d in days)
        {
            Debug.Log(d);
        }
    }
    
    public static int Sum(int a , int b)
    {
        
        Debug.Log(a + b);
        return a + b;
    }
}

