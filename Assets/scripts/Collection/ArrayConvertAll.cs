using UnityEngine;

public class ArrayConvertAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���ڿ� �迭�� ������ �迭�� ����
        string[] strArray = { "10", "20", "30" };
        int[] intArray = System.Array.ConvertAll(strArray,int.Parse);

        foreach(var n in intArray)
        {
            Debug.Log(n);
        }
    }

 
}
