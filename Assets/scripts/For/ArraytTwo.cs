using UnityEngine;

//2���� �迭 : ��� ���� �̷���� �迭

public class ArraytTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]�迭 ���� ,2���� �迭
        int[,] intArray;


        //[2]�迭 ��� ��(ũ��) ����
        intArray = new int[2,3];


        //[3]�迭 �ʱ�ȭ
        //0����
        intArray[0, 0] = 1;
        intArray[0, 1] = 2;
        intArray[0, 2] = 3;
       
        //1����
        intArray[1, 0] = 4;
        intArray[1, 1] = 5;
        intArray[1, 2] = 6;

        



        //[4]�迭 ���
        for (int i = 0; i < 2; i++)
        {
            for(int y = 0; y < 3; y++)
            {
                Debug.Log(intArray[i, y]);
            }
            
        }
        
    }

   
}
