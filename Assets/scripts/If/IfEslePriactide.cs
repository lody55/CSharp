using UnityEngine;


public class IfEslePriactide : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int score = 85;
        if (score >= 90)


        { Debug.Log("금메달"); }


        else if (score >= 80)
        { Debug.Log("은메달"); }

        else if (score >= 70)
        { Debug.Log("동메달"); }


        else
        {
            Debug.Log("노메달");
        }

    }
}
//[Q]
//score가 90이상이면 금메달 출력 80이상이면 은메달
//    70점 이상하면 동매달 출력 그외 다머지는 노메달 출려 scorer는 나머지는 노메달 출력
// score는 85점



    


