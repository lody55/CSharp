using UnityEngine;

// UnaryOperator (���׿�����) : +,-,
public class UnaryOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int�� ���� value�����ϰ� 0���� �ʱ�ȭ
        int value = 0;

        value = 8; //value��� ������ 8 ���� ���� ����ϸ� > 8
        //[1]
        value = +value;
        Debug.Log(value);
        //[2]
        value = -8; //value ������ -8 ����
        value = +value;
        Debug.Log(value);
        //[3]

        value = 8;
        value = -value;
        Debug.Log(value);

        //[4]
        value = -8;
        value = -value;
        Debug.Log(value);
    }


}
