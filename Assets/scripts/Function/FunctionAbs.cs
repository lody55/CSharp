using UnityEngine;

//abs(���밪)�� ���ϴ� �Լ� �����
// -5 >>> ���밪 5, 5�� ���밪 5 , -99 >>> 99 , 143 >>> 143
public class FunctionAbs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //-21�� ���밪�� ���ϰ� ����ϱ�
        int number = -21;
        //int abs = Abs(number);
        int abs = Mathf.Abs(number);
        Debug.Log($"{number}�� ���밪�� {abs}");
    }


    //�Ű������� ���� ������ ���밪�� ��ȯ�ϴ� �Լ�
    int Abs(int num)
    {
        //if(num < 0)
        //{
        //    return -num;
        //}   
        //else
        //{
        //    return num;
        //}

        return (num < 0) ? -num : num;
    }
}
