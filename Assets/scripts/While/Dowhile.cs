using UnityEngine;

//�ȳ��ϼ��並 3�� �����ϴ� ���α׷�
public class Dowhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int i = 1;

        //while (i<=3)
        //{
        //    Debug.Log("�ȳ��ϼ���");

        //    i++;
        //}

        int i = 1;

        do
        {
            //�ݺ����๮
            Debug.Log("�ȳ��ϼ���");

            //[2] ������
            i++;

        } while (i <= 3); //[3] ���ǽ�

        //for(int i = 1; i<=3; i++)
        //{
        //    Debug.Log($"�ȳ��ϼ���");
        //}
    } 
}
/*
 DoWhile�� = �ݺ���

���� �ݺ� ���๮�� 1�� �����Ѵ�
���ǽ��� true�̸� �ݺ����� �����Ѵ�
���ǽ��� false�� while���� �����Ѵ�

do (������ �ѹ� ������ �� ���� while ���ǽ����� �Ѿ)
{
    //�ݺ� ���๮
} While(���ǽ�)

 */
