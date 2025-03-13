using System.Collections;
using UnityEngine;

public class QueueNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]Queue클래스의 인스턴스(객체,개체) 생성
        Queue queue = new Queue();

        //[2]Queue에 데이터 입력 Enqueue
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        //[3]Queue에서 데이터 꺼내기
        
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());

    }


}
/*
Queue 클래스 : FIFO(First in First out) 형태로 데이터를 저장 관리하는 클래스
FIFO(First in First out) : 선입선출, 가장 먼저 넣은데 이터를 가장 먼저 꺼낸다.
- 터널형 창고 데이터 구조 ex (대기표 등등..)
 
Enqueue() : 큐에 데이터 넣기
Dequeue() : 큐에서 데이터 꺼내기

 */