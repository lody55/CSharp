using UnityEngine;

//break�� ���ѷ��� ���� ������
public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���ѷ��� - ���� �ݺ�
        //for (; ; )
        // {

        // }
        int number = 0;

        //number�� 5�̻��̸� while�� ����
        while(true)
        {
            //�ݺ� ���๮
            Debug.Log(number);

            number++;
            if(number >= 5)
            {
                break;
            }
        }
        
    }

}
