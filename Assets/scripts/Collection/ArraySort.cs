using UnityEngine;

//Sort(정렬) : 오름차순(1, 2, 3, 4 .....), 내림차순 (4, 3, 2, 1)
public class ArraySort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arr = { 3, 2, 1, 4, 5, 6};

        //sort - 오름차순 정렬
        
        for(int i = 0; i <arr.Length; i++)
        {
            Debug.Log(arr[i]);

        }
        Debug.Log("===============");
        System.Array.Sort(arr);
        foreach(var num in arr)
        {
            Debug.Log(num);

        }
        Debug.Log("=======================");

        //Revers - 현재 배열을 거꾸로
        System.Array.Reverse(arr);

        foreach (var num in arr)
        {
            Debug.Log(num);

        }
    }


}
