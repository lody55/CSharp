using UnityEngine;

// + : ���ϱ� ������ �߰� ���
// % : ������ ����
public class AdditionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello " + "World!!!"); // ���ڿ� ���ϱ� 
        Debug.Log("Hi" + " " + "EveryOne"); //Hi EveryOne
        Debug.Log("123" + "456"); //123456 > ���ڿ� + ���ڿ� >���ڿ�
        Debug.Log("123" + 456); //123456 > ���ڿ� + ���� > ���ڿ�

        Debug.Log(123 + "456"+ 789 + 890 + 1+3);// 123456789890 ���� + ���� > ���ڿ� > ���� +���� > ���ڿ� > ����+ ���� > ���ڿ�
        Debug.Log(123 + 456);//579 ���� + ���� = ����

        Debug.Log("123" + true);//123 true ���ڿ� + bool�� > ���ڿ�

        //Debug.Log("123" - 456); // ���ڿ����� ������ ������ ���� ����
    }

    
    
}
