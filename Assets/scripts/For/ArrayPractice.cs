using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int[,] intArray;

        //intArray = new int[3, 3];

        //intArray[0, 0] = 1;
        //intArray[0, 1] = 0;
        //intArray[0, 2] = 0;
        //intArray[1, 0] = 0;
        //intArray[1, 1] = 1;
        //intArray[1, 2] = 0;
        //intArray[2, 0] = 0;
        //intArray[2, 1] = 0;
        //intArray[2, 2] = 1;

        //for(int i = 0; i < 3;i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Debug.Log($"arr[{i},{j}] : {intArray[i,j]}");
        //    }
        //}

        // 3�� 3���� 2���� �迭�� ����
        int[,] arr = new int[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

        //�� �ʱ�ȭ
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                {
                    arr[i, j] = 1;
                }
                else //��� ���� �ε����� Ʋ���� 0
                {
                    arr[i, j] = 0;
                }

            }
            for (int y = 0; y < 3; y++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Debug.Log($"arr[{y},{j}] :{arr[y, j]}");
                }

            }
        }

    }

  
}
/*
 [Q]
 3��3���� 2���� �迭�� �����
 �迭�� ���� �ʱ�ȭ �ϴµ� 
 ��� ���� �ε����� ������ 1, ��� ���� �ε����� Ʋ���� 0���� �����ϼ���
 �����ϴ� ����� ���� for�� �̿��ϼ���

[output]
 1, 0, 0
 0, 1, 0
 0, 0, 1
 [���]
 arr[0,0] : 1
 arr[1,0] : 0
 .
 .
 .
 arr[2,2] : 1

 */