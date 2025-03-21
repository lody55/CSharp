using UnityEngine;
namespace Indexer
{
    public class IndexetNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Car클래스의 객체 생성
            Car car = new Car(3);
            car[0] = "제네시스";
            car[1] = "그랜져";
            car[2] = "아반떼";
            
            //인덱서 사용
            //for (int i = 0; i< car.Length;i++)
            //{
            //    Debug.Log(car[i]);
            //}
            foreach(var s in car) //배열이 아니라서 그냥car하면 빨간줄간다 >>> foreach를 사용할수 있게 해야함  
            {
                Debug.Log(s);
            }

            
        }

    }
}