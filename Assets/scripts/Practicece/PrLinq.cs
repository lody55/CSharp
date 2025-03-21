using UnityEngine;
using System.Collections.Generic;
using System.Linq;
namespace Practice
{
    public class PrLinq : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Dictionary<string, int> playergold = new Dictionary<string, int>();
            playergold.Add ( "전사", 1000);
            playergold.Add("마법사", 1600);
            playergold.Add("도적", 1400);
            playergold.Add("궁수", 1900);

            
           
            var richPlayer = playergold.Where(s => s.Value >= 1200);
            var sorted = richPlayer.OrderByDescending(s => s.Value).FirstOrDefault();
            double averagegold = playergold.Values.Average();
            
            Debug.Log($"전체 평균 골드 : {averagegold}");
            Debug.Log($"가장 많은 골드를 보유한 직업 : {sorted.Key}, 보유 골드 {sorted.Value}");
            //foreach (var s in sorted)
            //{
            //    Debug.Log($"직업 : {s.Key}, 보유골드 :{s.Value}");
            //}


        }
        
       

    }
}