using UnityEngine;

public class WhileDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        //for(int i = 0; i < 3; i++) �ݺ�Ƚ�� 3 - 0
        //for(int i = 1; i < 4; i++ ) �ݺ�Ƚ�� : 4 - 1
        //for(int i = 1; i <= 3; i++ )�ݺ�Ƚ�� : 3 - 1 + 1
        //(for(�ʱ��;���ǽ�;������)
        for (int i = 0; i < 3; i++)
        {
            //�ݺ� ���๮
            Debug.Log("�ȳ��ϼ���");

        }
        //[1] �ʱ��
        int o = 0;
        while (o<3) //[2] ���ǽ�
        {
            //�ݺ� ���๮
            Debug.Log("�ȳ��ϼ���");



            //������
            o++;
        }    
    }


}
/*
 while�� - �ݺ��� 
���ǽ��� true�̸� �ݺ��� ���� , false�� while�� ����

while(���ǽ�)
{
    �ݺ� ���๮ 
    
    ���ǽĿ� ���� ���� ������
}

���ǽ� �Ǻ�(��) >>> �ݺ��� ���� >>> ���ǽ� �Ǻ�(��) >>>> �ݺ��� ���� >>>> ���ǽ� �Ǻ�(����) >>>> while�� ����


 */