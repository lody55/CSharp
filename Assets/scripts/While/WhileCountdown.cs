using UnityEngine;

// 1, 2, 3, 4, 5
// 5, 4, 3, 2, 1
public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1���� 5���� 1�� ����
        //�ʱ��
        int i = 1;

        while (i <= 5) //���ǽ�
        {
            //�ݺ� ���๮
            Debug.Log($"ī��Ʈ �ٿ� : " +i);

            //������
            i++;
        }
        Debug.Log(" ====================================");

        //[2] 5���� 1���� 1�� ����
        //�ʱ��
        int y = 5;

        while (y >= 1)
        {
            Debug.Log($"ī��Ʈ �ٿ� : " + y);

            y--;


        }
                
    }

}
