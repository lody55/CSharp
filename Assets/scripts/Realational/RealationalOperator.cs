using UnityEngine;

//RealationalOperator(������ ������, �� ������)
// < (����) , <= (�۰ų� ����) , >(ŭ) , >=(ũ�ų� ����), ==(����), !=(�ٸ�)  ------�񱳿�����
// ��� : true(��) , false(����)
public class RealationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;
        Debug.Log(x < y); //x(3)�� y(5)���� ������?  >>>> true
        Debug.Log(x <= y); //true
        Debug.Log(x >y); // false
        Debug.Log(x >= y); //false
        Debug.Log(x == y); //false
        Debug.Log(x != y); //true

        Debug.Log("AAA" == "aaa");// false


    }

}
