using UnityEngine;

public class FunctionPractice : MonoBehaviour
{

    void Hi(string msg) => Debug.Log(msg);


    int SSubtract(int x, int y) => x - y; // ȭ��ǥ �Լ� , ���ٽ� , ����� �Լ�
    int MMultiply(int x, int y) => x * y;
    int DDevid(int x, int y) => x / y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result;
        result = Add(5, 3);
        Debug.Log(result);
        result = Subtract(5, 3);
        Debug.Log(result);
        result = SSubtract(5, 3);
        Debug.Log(result);
        result = Multiply(5, 3);
        Debug.Log(result);
        result = MMultiply(5, 3);
        Debug.Log(result);
        result = Devide(5, 3);
        Debug.Log(result);
        result = DDevid(5, 3);
        Debug.Log(result);
        result = Remainder(5, 3);
        Debug.Log(result);

        Hi("�ȳ��ϼ���");
    }
    int Add(int x, int y)
    {
        return x + y;

    }
    int Subtract(int x, int y)
    {
        return x - y;
    }
    int Multiply(int x, int y)
    {
        return x * y;
    }
    
    int Devide(int x, int y)
    {
        return x / y;
    }    
    int Remainder(int x , int y)
    {
        return x % y;
    }
}

/*
 [Q]
 ��Ģ������ ���ϴ� �Լ� �����
 + , - , * , / , %
 �ΰ��� ������ �Է¹޾� ����Ͽ� 
 ������� ��ȯ�ϴ� �Լ� ����� (5����)
 �Լ��̸� Add, Subtract , Multiply , Devide, Remainder
�Է°�  : 5 , 3
[output]
 
 */