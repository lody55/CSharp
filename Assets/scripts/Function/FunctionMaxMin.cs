using UnityEngine;

//
public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //3,5�� �Է¹޾� ū ���� ����ϱ�
        int max = GetMax(3, 5);
        Debug.Log($"3�� 5�� ū ����? {max}�Դϴ�.");

        int min = Getmin(-3, -5);
        Debug.Log($"-3�� -5�� ���� ����? {min}�Դϴ�.");

    }

    //1. �Ű������� �Է� ���� �� ���� ���� �� ū ���� ��ȯ�ϴ� �Լ�
    int GetMax(int x , int y)
    {
        //int maxvalue;
        //if(x>y)
        //{
        //    maxvalue = x;
        //}
        //else
        //{
        //    maxvalue = y;
        //}
        //return maxvalue;
        //3�� ������
        //int maxvalue = (x > y) ? x : y;
        //return maxvalue;
        //return (x > y) ? x : y;
        if(x > y)
        {
            return x;
        }    
        else
        {
            return y;
        }
    }

    int Getmin(int x, int y)
    {
        if(x <y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }    
    
}

/*
 [Q]
1. �Ű������� �Է� ���� �� ���� ���� �� ū ���� ��ȯ�ϴ� �Լ�
2. �Ű������� �Է� ���� �� ���� ���� �� ���� ���� ��ȯ�ϴ� �Լ�
3. 3,5�� �Է¹޾� ū �� ����ϱ�
4. -3 , -5�� �Է¹޾� ���� �� ����ϱ�
 
[output]
3�� 5�� ū ���� (��ȯ ��) �̴�
-3�� -5 �� ���� ���� (��ȯ ��) �̴�

 
 */