using UnityEngine;

// break; : �ݺ������� (for,while)���� {}�� ���������� ��ɹ�
// �ݺ��� �ȿ��� break;���� ������ ��� �ݺ����� �����Ѵ�

public class BreakFo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�ȳ��ϼ��並 5�� ����ϴ� ���α׷�
        // i = 2�϶� for���� ����
        for (int i = 1; i <= 5; i++)
        {
            //�ݺ� ���๮
            Debug.Log("�ȳ��ϼ���");

            if (i == 2)
            {
                break;
            }
        }

        // ���ǹ� �� >> ��� >> if�� ���� >> ���ǹ� �� >> ��� if�� true >>�극��ũ ���� >> for�� ����

    }
}
