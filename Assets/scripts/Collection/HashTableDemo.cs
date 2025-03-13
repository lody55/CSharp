using UnityEngine;
using System.Collections;


//HashTable : ���� ����, ���ڿ� ������ �ε����� ����Ͽ� ������(��)���� ����, �����ϴ� Ŭ����
//[0], [1], [2], ["���ڿ�"], ["�̸�"]
public class HashTableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] HashTable Ŭ������ �ν��Ͻ�(��ü,��ü) ����
        Hashtable hash = new Hashtable();

        //[2] ������ �ֱ� : ����, ���ڿ� ������ �ε��� ���
        hash[0] = "���ѹα�";
        hash["���̸�"] = "����Ư����";
        hash["���̸�"] = "������";

        //[3] ������ ����ϱ�
        //Debug.Log(hash[0]);
        //Debug.Log(hash["���̸�"]);
        //Debug.Log(hash["���̸�"]);

        foreach(var o in hash.Keys)
        {
            Debug.Log($"{o.ToString()} - {hash[o]}");
        }
    }

 
}
