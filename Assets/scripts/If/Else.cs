using UnityEngine;

public class Else : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���� score�� 60�̻��̸� "�հ�" ���
        // �ƴϸ� " ���հ�" ���
        // score�� 61��
        int score = 59;// [1]

        if (score >= 60)
        {

            Debug.Log("�հ�"); //[2]
        }
        else
        {
            Debug.Log("���հ�"); //[3]

        }
        Debug.Log("����"); //[4]




    }
    //score = 59; : [1] >> [3] >> [4]
    //score = 61; : [1] >> [2] >> [4]


}
