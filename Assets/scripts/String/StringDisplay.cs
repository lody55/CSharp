using UnityEngine;


//���ڿ� ���� ���(���ڿ� �ٹ̱�)
public class StringDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var displayName = "";
        var fistname = "�浿";
        var lastname = "ȫ";

        //output : "�̸� : ȫ�浿"

        //[1] string ���ϱ�(+) ������ ���
        displayName = "�̸� : " + lastname + fistname;

        Debug.Log(displayName);

        //[2] string.Format() �޼��� ���
        displayName = string.Format("�̸� :{0}{1}", lastname, fistname);
        Debug.Log(displayName);
    }

  
}
