using UnityEngine;
using System.Linq;
using System.Collections.Generic;

//LinkWhere (Where절, 조건절)

public class LinqWhere : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수형 배열 numbers의 요소 중 3보다크고 짝수인 수들 구하기
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //IEnumerable<int> newnumbers = numbers.Where(n => n > 3);
        // IEnumerable<int> newnumbers = numbers.Where(n => n > 3 && n % 2 == 0);
        List<int> newnumbers = numbers.Where(n => n > 3 && n % 2 == 0).ToList();

        foreach (var n in newnumbers)
        {
            Debug.Log(n);
        }
    }

 
}
