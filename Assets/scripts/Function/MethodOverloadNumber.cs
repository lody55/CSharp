using UnityEngine;


//MethodOverload(�ż��� �����ε�, �Լ� ���� ����)
// : ������ �̸��� �޼��带 �Ű������� �޸��ؼ� ������ �����ϴ� ��
public class MethodOverloadNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintNumber(1234);
        PrintNumber(1234L);
        PrintNumber(1234F);
    }

    //�Ű������� ���ڸ� �Է¹޾� ����ϴ� �Լ� : PrintNumber
    //int Ÿ���� ������ �Ű������� �Է¹޾� ���
    void PrintNumber(int number)
    {
        Debug.Log($"Int32 : {number}");
    }
    //long Ÿ���� ������ �Ű������� �Է¹޾� ���
    void PrintNumber(long number)
    {
        Debug.Log($"Int64 : {number}");
    }
    //float Ÿ���� �Ǽ��� �Ű������� �Է¹޾� ���
    void PrintNumber(float number)
    {
        Debug.Log($"�Ǽ��� : {number}");

    }
    //double

}
