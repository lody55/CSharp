using UnityEngine;

public class Constant : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���� 
        string name = "ȫ�浿";
        name = "�̼���";  // �������� �� > ������ ����
        
        //���
        const int Age = 20;
        //Age = 21;  // ���� �Ұ��� > ����� ����


        //���� , ��� ���
        Debug.Log($"{name} - {Age}");

    }


}
