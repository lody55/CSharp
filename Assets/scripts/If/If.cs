using UnityEngine;

// ���� Score�� 60�� �̻��̸� "�հ�"�̶�� ���, 
//Score�� 61��
public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // if(score�� 60�� �̻�)
        //          { 

        //            "�հ�" �̶�� ���

        //    }

        int score = 61;
        if (score >= 60) // ���ǹ��� ���̸� ��Ͼȿ� �ִ� ���๮ ����
        {
            //���๮
            Debug.Log("�հ�");

        }

    }


}

/*
 If�� - ���ǹ�
���ǽ��� ���϶��� ���๮�� �˴ϴ�.
���ǽ��� �����̸� ���๮�� �������� �ʽ��ϴ�.


//���� ���ǽ��� ���̸� {} �ȿ� �ִ� ���๮�� �����϶�

If(���ǽ�)
{
    ���๮1
    ���๮2
    ���๮ ����.......

}
 if(bool)

{
    ���๮
    ���๮ ����....
}
 */