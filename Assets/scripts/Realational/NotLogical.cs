using UnityEngine;

//NotOperator (���� ������, Not) : ! ���̸� �����̰� �����̸� ��   <<< ���� ������
// ����� true , false

public class NotLogical : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� ��
        Debug.Log(!true); // >>>>> ��� :  false

        // [2] ������ ��
        Debug.Log(!false); // >>>> ��� : true

        // [3] 
        bool bln = false;
        Debug.Log(!bln); // >>>>>   true
        Debug.Log(!!bln); // >>>>> false
        Debug.Log(!(!(!bln))); //>>>>>> true



    }

  
}
