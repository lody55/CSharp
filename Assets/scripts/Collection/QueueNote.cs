using System.Collections;
using UnityEngine;

public class QueueNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]QueueŬ������ �ν��Ͻ�(��ü,��ü) ����
        Queue queue = new Queue();

        //[2]Queue�� ������ �Է� Enqueue
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        //[3]Queue���� ������ ������
        
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());

    }


}
/*
Queue Ŭ���� : FIFO(First in First out) ���·� �����͸� ���� �����ϴ� Ŭ����
FIFO(First in First out) : ���Լ���, ���� ���� ������ ���͸� ���� ���� ������.
- �ͳ��� â�� ������ ���� ex (���ǥ ���..)
 
Enqueue() : ť�� ������ �ֱ�
Dequeue() : ť���� ������ ������

 */