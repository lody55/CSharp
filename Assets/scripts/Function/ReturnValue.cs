using UnityEngine;

//��ȯ���� �ִ� �Լ� ����� ȣ���ϱ�

public class ReturnValue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]��ȯ ���� �ִ� �Լ� ȣ��(���)
        //��ȯ ���� �޾��� ���� �����ϰ� ��ȯ�Ǵ� �� ����
        string returnvalue =  Getstring();
        Debug.Log(returnvalue);

    }

    //[1]��ȯ���� �ִ� �Լ� �����(����,����)
    //��ȯ�� �̶�� ���ڿ�(string)�� ��ȯ�ϴ�  �Լ�
    string Getstring()
    {
        return "��ȯ ��(Return Value)";
    }

   
}
