using UnityEngine;

//&&, ||
public class IfAnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 1234;
        int age = 20;
        string name = "ȫ�浿";
        // ���ǽ� 2�� : number�� 1234�� ����? , number�� 1000�̻��̳�?
        // 2���� ������ ��� �����ϸ� �½��ϴ� ���
        if(number == 1234 && number >= 1000)
        {
            Debug.Log("�½��ϴ�");

        }

        // ���ǽ��� 1234�� ����? , 1000���ϳ�?
        // 2���� ���� �� �ϳ��� �����ϸ� ���(���๮ ����)
        /*if (number == 1234 || number <= 1000)
        {
            Debug.Log("�ϳ��� ���̸� ��");




        }
       */
        if (name == "ȫ�浿" && age == 20)
            
        {
            Debug.Log($"�̸���{name}, ���̴� {age}");

        
        }
        
    }
    
   
}
