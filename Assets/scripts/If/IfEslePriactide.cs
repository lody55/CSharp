using UnityEngine;


public class IfEslePriactide : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int score = 95;
        string medal = "";


        if (score >= 90)


        {
            medal = "�ݸ޴�";
        }


        else
        {
            if (score >= 80)
            {
                medal = "���޴�";
            }
            else
            {
                if (score >= 70)
                    medal = "���޴�";
                else
                {
                    medal = "��޴�";
                }

            }


        }
        Debug.Log(medal + "�����ϼ˽��ϴ�");

    }
}
//[Q]
//score�� 90�̻��̸� �ݸ޴� ��� 80�̻��̸� ���޴�
//    70�� �̻��ϸ� ���Ŵ� ��� �׿� �ٸ����� ��޴� ��� scorer�� �������� ��޴� ���
// score�� 85��



    


