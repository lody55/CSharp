using UnityEngine;

//���� ���� , �������� , 
public class FunctionScope : MonoBehaviour
{
    string message = "���� ����"; //�ʵ�, ��� ����
    

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowMessage();
        Debug.Log(message);
        PrintMessage();
    }

    //message�� ����ϴ� �Լ�
    void ShowMessage()
    {
        string message = "���� ����";
        Debug.Log(message);
    }

    void PrintMessage()
    {
        Debug.Log(message);
    }

}
