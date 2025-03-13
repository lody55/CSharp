using UnityEngine;
using System.Collections;
public class StackNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Stack Ŭ������ �ν��Ͻ�(��ü,��ü) ����
        Stack stack = new Stack();

        //[2] Push�� ������ ����
        stack.Push("���ѹα�");
        stack.Push("����Ư����");
        stack.Push("������");

        //[3] peek() ������ ���� ���(������)�� �����͸� ��ȯ
        Debug.Log($"{stack.Peek()},{stack.Count}");

        //[4]Pop() ���ÿ��� ������ ������
        stack.Pop();

        //[5] peek() ������ ���� ���(������)�� �����͸� ��ȯ
        Debug.Log($"{stack.Peek()},{stack.Count}");

        //[6]Pop() ���ؿ��� ������ ������
        if(stack.Count>0)
        {
            stack.Pop();
            Debug.Log($"{stack.Peek()},{stack.Count}");
        }
        //[7]���� ����
        stack.Clear();
        Debug.Log($"{stack.Count}");


    }


}
