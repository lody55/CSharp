using UnityEngine;

// ���� �������� �����ϴ� ����ü
// [1] ����ü ���� , ����

struct BusinessCard
{
    public string name; //�� �̸�
    public int age; // �� ����
    public int Number; //�� ��ȭ��ȣ
    public string address; // �� �ּ�



}
public class StructNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ����ü ������ ���� ����
        BusinessCard MyCard;

        //[3] ����ü�� �����ִ� �����͵��� �ʱ�ȭ
        MyCard.name = "ȫ�浿";
        MyCard.age = 34;
        MyCard.Number = 3810;
        MyCard.address = "��⵵ �����ֽ�";
        //[4] ����ü ���
        Debug.Log($"�̸��� {MyCard.name} ���̴� {MyCard.age} ��ȭ��ȣ�� {MyCard.Number} �ּҴ� {MyCard.address}");



    }



}
