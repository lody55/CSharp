using UnityEngine;

//��ø ����ü : ����ü �ȿ� ����ü
//������ �����ϴ� ����ü �����

//������ ������ �����ϴ� ����ü ����
struct Score
{
    public int kor; // ��������
    public int eng; // ��������
    public int math; // ��������

}
//�л� ������ �����ϴ� ����ü ���� - ���� ����
struct Student
{
    public int number; // �л� ��ȣ
    public string name; // �л� �̸�
    public Score scores; //������� ���� - Score ����ü : ��ø ����
    
    

}



public class StructPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] �л� ����ü �迭 ���� ���� �� ��Ҽ� ����
        Student[] students = new Student[3];

        //[2] �л� ����ü �ʱ�ȭ
        students[0].number = 1;
        students[0].name = "ȫ�浿";
        students[0].scores.kor = 100;
        students[0].scores.math = 80;
        students[0].scores.eng = 90;

        students[1].number = 2;
        students[1].name = "��λ�";
        students[1].scores.kor = 70;
        students[1].scores.math = 99;
        students[1].scores.eng = 85;

        students[2].number = 3;
        students[2].name = "�Ӳ���";
        students[2].scores.kor = 40;
        students[2].scores.math = 45;
        students[2].scores.eng = 30;

        for(int i=0; i <students.Length; i++)
        {
            Debug.Log($"{students[i].number} - {students[i].name} - ����{students[i].scores.kor} - ����{students[i].scores.eng} - ����{students[i].scores.math}");
        }
    }


}
