using UnityEngine;

// string == system.String�� ��Ī
//����(��)�� ���� ���ϱ� :�迭�̸�.Length 
public class StringClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "Hello";
        System.String s2 = "�ݰ����ϴ�";

        Debug.Log($"{s1} ���� : {s1.Length} , {s2} ���� : {s2.Length}");

        //���� 

    }


}
