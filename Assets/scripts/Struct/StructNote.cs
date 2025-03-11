using UnityEngine;

// 명함 데이터의 관리하는 구조체
// [1] 구조체 정의 , 선언

struct BusinessCard
{
    public string name; //고객 이름
    public int age; // 고객 나이
    public int Number; //고객 전화번호
    public string address; // 고객 주소



}
public class StructNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] 구조체 형식의 변수 선언
        BusinessCard MyCard;

        //[3] 구조체에 속해있는 데이터들의 초기화
        MyCard.name = "홍길동";
        MyCard.age = 34;
        MyCard.Number = 3810;
        MyCard.address = "경기도 남양주시";
        //[4] 구조체 사용
        Debug.Log($"이름은 {MyCard.name} 나이는 {MyCard.age} 전화번호는 {MyCard.Number} 주소는 {MyCard.address}");



    }



}
