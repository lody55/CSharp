using UnityEngine;

//As ������ : ~ ���� ��ȯ�ϱ�, ������ �������� ��ȯ�� �����ϸ� ��ȯ, ��ȯ�� �Ұ��ϸ� null�� ��ȯ �մϴ�. 
public class AsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        object s = "�ݰ����ϴ�";
        string r1 = s as string;
        Debug.Log(r1);

        object i = 1234;
        string r2 = i as string;
        if (r2 == null)
        {
            Debug.Log("null �Դϴ�");
        }
        object i2 = 5678;
        if(i2 is string)
        {
            string r3 = i2 as string;
            Debug.Log($"{r3} ");
        }
        else
        {
            Debug.Log("��ȯ�Ұ� �մϴ�");
        }
    
    }

    
}
