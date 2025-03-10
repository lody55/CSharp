using UnityEngine;

//Foreach : �迭�� ����� ������ ������� ��� �����ͼ� ���
public class ArrayForeach : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�迭 ��ҵ��� ���� ��� �����ͼ� �� ���� ���ϴ� ���α׷� ����
        float[] arr = {10.5f,20.1f,30.3f};
        float sum = 0f;

        //for(int i = 0; i<3; i++)
        //{
        //    sum = sum + arr[i];
        //}
        //�迭�� �ݺ����� ���� ���δ�
        
        foreach(float f in arr) // ������ ���� ���� �� �ݺ��� ����
        {
            //�ݺ� ���๮
            sum = sum + f;

        }

        Debug.Log($"������ {sum}");
    }

    
 
}
/*
 Foreach�� : �迭�� ����� ������ ������� ��� �����ͼ� ���
 �迭�� �����͸� ó������ ������ �������� ���̻� ������ �����Ͱ� ���� �� �ݺ��� ���� 

 foreach(�迭�� ������ Ÿ�� ���� �̸� in �迭���� �̸�)
 {
       //�ݺ� ���๮
 }
 
 */