using UnityEngine;
using System.Collections.Generic;
using System.Linq;
namespace Pr
{
    public class LinqPr : MonoBehaviour
    {
        Dictionary<string, int> gold = new Dictionary<string, int>()
        {
            {"전사",1000 },
            {"마법사",1600 },
            {"도적", 1800 },
            {"궁수", 1200 }
        };
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            List<string> score = gold.Keys.ToList();

            var job = score.Select(m => m.ToUpper());

            foreach(var s in job)
            {
                Debug.Log($"대문자 변경 : {s}");
            }
        }
         
    }
}