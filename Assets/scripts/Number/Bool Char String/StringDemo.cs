using UnityEngine;

// string(���ڿ�) = ����(��)�� ������ ���� 

public class StringDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���ڿ� ���� �����ϰ� ȫ�浿���� �ʱ�ȭ

        string name = "ȫ�浿";

        //[1] ����ϱ�
        Debug.Log("�ȳ��ϼ��� " + name + " �Դϴ�.");

        string multiLine = @"
                �ȳ��ϼ���
                �ݰ����ϴ�

        ";

        Debug.Log(multiLine);
        
    }

  
}
