using UnityEngine;

//[1] 동물들을 구분하는 열거형 생성
// 열거형 값은 순서대로 0부터 시작해서 1씩 증가한다
enum Animale
{
    Horse, //0
    Sheep = 5,  //1 >>> 수 지정하면 지정 값으로 바뀜
    Monkey,  //2  >>>>> 지정값+1
    Pig //3  >>>>> 지정값 +2
       
}

public class EnumIndexChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((int)Animale.Monkey); 
    }

 
}
