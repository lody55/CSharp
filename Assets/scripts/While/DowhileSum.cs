using Unity.VisualScripting;
using UnityEngine;

//Dowhile���� �̿��ؼ� 1���� n(100)������ �����߿��� ¦���� ���� ���ϴ� ���α׷� ����
public class DowhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1; //�ʱ��
       
        int n = 100;
        int sum = 0;


        do
        {
            if (i % 2 == 0)
            {
                sum = sum + i;
            }

            i++;
        }
        while (i <= n);

            {
            Debug.Log($"¦���� ���� {sum}");
            

            }

    }    
   

  
}
