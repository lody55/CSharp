using UnityEngine;

//continue���� �ݺ������� continue���� ������continue�� �Ʒ��� �ִ� ���๮�� �������� �ʰ� 
// ���� �ݺ����� ���ǽ��� �Ǻ��� ���� �ݺ����� ���� �մϴ�.

public class ContinueFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1~5���� Ȧ���� ����ϴ� ���α׷�
        for (int i = 1; i <= 5; i++) 
        {
            //if (i % 2 != 0) // Ȧ�� �Ǻ���
            if(i % 2 ==0) //¦�� �Ǻ���
            {
                continue; // ���� �ݺ� �������� �ݺ����� �����ϰ� ���� �ݺ������� �̵�
            }

                Debug.Log(i);
            
        }
    }

 
}
