// using unityengine ����� ��
/*
using UnityEngine;

public class UsingDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("hello world");

    }

    
}
*/

// usig ������� ������

public class UsingDemo : UnityEngine.MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���ӽ����̽�.Ŭ����.�޼���(�Լ�)()

        UnityEngine.Debug.Log("hello world");
    }
}