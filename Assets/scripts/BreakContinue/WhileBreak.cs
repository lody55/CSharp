using UnityEngine;

//"1부터 10까지의 정수의 합을 구하는 프로그램 구현"
// 구한 합(sum)이 22(goal)이상이 되면 더이상 합을 구하지 않는다
// while문 이용
public class WhileBreak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1;
        int n = 10;
        int sum = 0;
        int goal = 22;

        while(i <= n )
        {
            sum = sum + i;

            if (sum >= goal)
            {
                break;
            }
            i++;
        }

        
            

        Debug.Log(sum);

    }

}
