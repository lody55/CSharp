using UnityEngine;

// 1���� 5���� 1�� �����ϸ鼭 ���� ����ϴ� ���α׷�
//[output]
// count : 1 
// count : 2
// count : 3
// count : 4
// count : 5

public class For : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1���� 5���� 1�� �����ϸ鼭 ���� ��� >> 5�� �ݺ�
        //for (int i = 1; i < 6; i++)
        //{
        //    Debug.Log($"Count: " + i);
        //}

        //for(int i = 1; i <= 5; i++)

        //{
        //        Debug.Log($"Count: " + i);
        //}
        for(int i = 0; i < 5; i++ )
        {
                Debug.Log($"Count: { i + 1}");
        }
    }

}
