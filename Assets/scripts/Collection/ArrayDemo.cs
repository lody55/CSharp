using UnityEngine;

//Collection(�÷���) : �迭ó�� Ư�� �׸��� ������ �����ϴ� �׸�
// �迭 , ����Ʈ, ��ųʸ� ���� ����Ͽ� ���� ��ü�� �׷��� ����� �����Ѵ�
public class ArrayDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] colors = { "Red", "Green", "Blue" };

        Debug.Log($"�迭�� ��Ҽ� ���� : {colors.Length}");

        for(int i = 0; i<colors.Length; i++)
        {
            Debug.Log(colors[i]);
        }
    }

 
}
