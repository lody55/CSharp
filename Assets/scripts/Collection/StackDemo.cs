using UnityEngine;
using System.Collections;
public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]StackŬ������ ��ü(�ν��Ͻ�,��ü) ����
        Stack stack = new Stack();

        //[2]������ �Է�
        stack.Push("ù��°");
        stack.Push("�ι�°");
        stack.Push("����°");

        //[3]������ ��������
        Debug.Log(stack.Pop());
        stack.Push("����°");
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());

        //����
        try
        {
            Debug.Log(stack.Pop());//����־ ��������
        }
        catch(System.Exception ex)
        {
            Debug.Log($"�������� : {ex.Message}");
        }


    }


}
/*
Stack Ŭ���� : LIFO (Last In First Out) ���·� �����͸� ���� �����ϴ� Ŭ����
LIFO (Last In First Out) : ���Լ��� , �������� ���� �����͸� ���� ���� ������
 - �ֹ��� ���ø� �׾Ƴ��� ������ ������ ���� , �칰(����)�� ������ ����

Push() : ���� ������ ������ �Է�
Pop() : ���� �������� ������ ���
peek() : ���� ������ ������ �� ���� ���(�������� �Է�)�� �������� ���� ��ȯ
count : ���ÿ� ���� ����Ǿ� �ִ� ������ ��

Overflow : ������ ���� á�� �� �߻�
Underflow : ������ ����� �� �߻�
 
 */