using UnityEngine;

public class ArrayTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1���� �迭 ����, ��� ��(����)���� , �� �ʱ�ȭ�� ���ÿ� 

        // int[] intArray = new int[3] { 1, 2, 3 };
        // [1 -2] 1���� �迭 ���� ��� ��(����) �����ϸ鼭 ũ�� ����, �� �ʱ�ȭ�� ���ÿ�
        //int[] intArray = new int[] { 1, 2, 3,4 };
        // [1 -2] 1���� �迭 ����, �� �ʱ�ȭ�� ���ÿ�
        int[] intArray = { 1, 2, 3, 4 };


        //[4] �迭�� ���
        for (int i = 0; i < 4; i++)
        {
            Debug.Log($"{i}��° ���� ���� : {intArray[i]}");
        }

    }

}
