using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����
        int x = 2;//[1]

        switch(x)
        {
            case 1://[2]
                Debug.Log("x�� 1 �Դϴ�"); //[2] ���๮1
                break;
            case 2://[3]
                Debug.Log("x�� 2 �Դϴ�");//[3] ���๮ 2
                break;
        }
        //[4] ���๮3
        Debug.Log("���α׷� ����");


        // [1] >> [3] >> [4]
        // int x = 2;
        // x =1 �� ��
        // [1] >>> [2] >>> [4]

    }

}
/*
 Switch�� : ���ǹ� - ���ù�

switch(����) : Data�� �Ǻ�
{
    case 1�� :
          //���๮1
        break;

    case 2�� :
          //���๮2
        break;         

    case 3�� :
          //���๮3
        break;
    defalt : ��� case�� �ƴϸ�
          //���๮4
        break;
}

if(���ǽ�) : ���ǽ��� ��, ���� �Ǻ�
{
    ���๮1
}
else
{
    ���๮2
}


 */