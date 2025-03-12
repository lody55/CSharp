using UnityEngine;

//로또 번호 생성기
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Random 클래스 객체(개체,인스턴스) 생성
        System.Random random = new System.Random();

        //for (int i = 0; i <6; i++)
        //{
        //    Debug.Log(random.Next(1, 46));
        //}

        //배열 변수 선언 및 요소수 생성
        int[] numbers = new int[6];
        bool flag = false; //중복검사해서 중복이면 true, 아니면 false

        // 
        int number = 0; // 랜덤값을 저장하는 변수


        for (int i = 0; i <6; i++)
        {
            //1~45의 랜덤값을 받아온다
            number = random.Next(1, 46);
            //중복검사 - number와 먼저 뽑힌 로또번호와 비교
            flag = false;
            if( i > 0)
            {
                for(int j = 0; j < i; j++)
                {
                    if (numbers[j]==number)
                    {
                        flag = true;
                    }
                }
            }


            if(flag == false) // 중복이 아니면 
            {
                numbers[i] = number;
            }
            else // 중복이면 다시 계산하기 위해 인덱스를 조정한다
            {
                i--;
            }
        }
        // 로또번호 출력
        for (int i = 0; i <numbers.Length;i++)
        {
            Debug.Log(numbers[i]);
        }
    }

  
}
/*
 numbers[0] 중복검사 x
 numbers[1] 중복검사 [0]번과 비교 >> 중복이면 사용못함
 numbers[2] 중복검사 [0],[1]번과 비교
 numbers[3] 중복검사 [0],[1],[2]번과 비교
 numbers[4] 중복검사 [0],[1],[2],[3]번과 비교
 numbers[5] 중복검사 [0],[1],[2],[3],[4]번과 비교

 
 
 */
/*
 [Q]
 로또 번호 생성기 만들기
 [1] 6개 번호
 [2] 1~45번 사이의 랜덤번호
 [3] 중복된 숫자가 있으면 안된다

 [output]
 조건에 맞는 번호 6개 출력
 */