using UnityEngine;

//�ζ� ��ȣ ������
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Random Ŭ���� ��ü(��ü,�ν��Ͻ�) ����
        System.Random random = new System.Random();

        //for (int i = 0; i <6; i++)
        //{
        //    Debug.Log(random.Next(1, 46));
        //}

        //�迭 ���� ���� �� ��Ҽ� ����
        int[] numbers = new int[6];
        bool flag = false; //�ߺ��˻��ؼ� �ߺ��̸� true, �ƴϸ� false

        // 
        int number = 0; // �������� �����ϴ� ����


        for (int i = 0; i <6; i++)
        {
            //1~45�� �������� �޾ƿ´�
            number = random.Next(1, 46);
            //�ߺ��˻� - number�� ���� ���� �ζǹ�ȣ�� ��
            flag = false;
            if( i > 0)
            {
                for(int j = 0; j < i; j++)
                {
                    if (numbers[j]==number)
                    {
                        flag = true;
                    }
                }
            }


            if(flag == false) // �ߺ��� �ƴϸ� 
            {
                numbers[i] = number;
            }
            else // �ߺ��̸� �ٽ� ����ϱ� ���� �ε����� �����Ѵ�
            {
                i--;
            }
        }
        // �ζǹ�ȣ ���
        for (int i = 0; i <numbers.Length;i++)
        {
            Debug.Log(numbers[i]);
        }
    }

  
}
/*
 numbers[0] �ߺ��˻� x
 numbers[1] �ߺ��˻� [0]���� �� >> �ߺ��̸� ������
 numbers[2] �ߺ��˻� [0],[1]���� ��
 numbers[3] �ߺ��˻� [0],[1],[2]���� ��
 numbers[4] �ߺ��˻� [0],[1],[2],[3]���� ��
 numbers[5] �ߺ��˻� [0],[1],[2],[3],[4]���� ��

 
 
 */
/*
 [Q]
 �ζ� ��ȣ ������ �����
 [1] 6�� ��ȣ
 [2] 1~45�� ������ ������ȣ
 [3] �ߺ��� ���ڰ� ������ �ȵȴ�

 [output]
 ���ǿ� �´� ��ȣ 6�� ���
 */