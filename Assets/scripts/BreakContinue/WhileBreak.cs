using UnityEngine;

//"1���� 10������ ������ ���� ���ϴ� ���α׷� ����"
// ���� ��(sum)�� 22(goal)�̻��� �Ǹ� ���̻� ���� ������ �ʴ´�
// while�� �̿�
public class WhileBreak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1;
        int n = 10;
        int sum = 0;
        int goal = 22;

        while(i <= n )
        {
            sum = sum + i;

            if (sum >= goal)
            {
                break;
            }
            i++;
        }

        
            

        Debug.Log(sum);

    }

}
