using System.Collections;
using UnityEngine;

// Collections : Stack , Queue, ArrayList, Hashtable
public class StackClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Stack Ŭ������ �ν��Ͻ�(��ü) ����
        Stack st = new Stack();

        //Stack�� ������ �ֱ� : Push(�޼���)
        st.Push("First");
        st.Push("Second");

        //Stack���� ������ ������ : Pop
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());

    }

 
}
