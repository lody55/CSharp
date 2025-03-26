using UnityEngine;
using GenericClass;
using System.Collections.Generic;


// 형식 매개변수 T에 지정한 형식으로 클래스와 멤버의 성질이 결정되는 클래스

//클래스 사용자 정의 형식
public class GenericCollection : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //학생 전용 리스트
        List<Student> students = new List<Student>
        {
            new Student { name = "홍길동", number = 1},
            new Student { name = "백두산", number = 2},
            new Student { name = "장길산", number =3}
        };

        Student student = new Student() { name = "김단비", number = 4 };
        students.Add(student);

        foreach (var s in students)
        {
            Debug.Log($"{s.name} - {s.number}");
        }
    }

}
