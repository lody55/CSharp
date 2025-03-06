using UnityEngine;


public class IfEslePriactide : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int score = 95;
        string medal = "";


        if (score >= 90)


        {
            medal = "금메달";
        }


        else
        {
            if (score >= 80)
            {
                medal = "은메달";
            }
            else
            {
                if (score >= 70)
                    medal = "동메달";
                else
                {
                    medal = "노메달";
                }

            }


        }
        Debug.Log(medal + "수상하셧습니다");

    }
}
//[Q]
//score가 90이상이면 금메달 출력 80이상이면 은메달
//    70점 이상하면 동매달 출력 그외 다머지는 노메달 출려 scorer는 나머지는 노메달 출력
// score는 85점



    


