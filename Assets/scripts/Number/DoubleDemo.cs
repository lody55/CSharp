using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //double pi = 3.141592; // 64��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ
        //float f = 3.14f; // 32��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ
        //decimal d = 12.34m; // 128��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ

        //Debug.Log(pi);
        //Debug.Log(f);
        //Debug.Log(d);

        double doublemin = double.MinValue;
        double doublemax = double.MaxValue;

        Debug.Log("Double �ּҰ�"+ doublemin);
        Debug.Log("Double �ִ밪" + doublemax);
        float floatmin = float.MinValue;
        float floatmax = float.MaxValue;

        Debug.Log("folat �ּҰ�" + floatmin);
        Debug.Log("float �ִ밪" + floatmax);



            
    }

}
