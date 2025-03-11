using UnityEngine;


//[1] ����ü ����, ���� : ���� �����͸� �����ϴ� ����ü
struct UserInfo
{
    public string name; // �� �̸�
    public int age;  // �� ����
    // ...... ���

}
public class structArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����ü ���� ����
        UserInfo info;
        //[2] ����ü �ʱ�ȭ
        info.name = "ȫ�浿";
        info.age = 20;
        //[3] ����ü ���
        // PrintUserInfo(info.name, info.age);
        PrintUserInfo(info);

        //[1] ����ü�� �迭 ���� ����, �迭�� ��Ҽ�(ũ��) ����
        UserInfo[] UserInfos = new UserInfo[2];
        //[2] ����ü �迭�� �ʱ�ȭ
        UserInfos[0].name = "��λ�";
        UserInfos[0].age = 22;
        UserInfos[1].name = "�Ӳ���";
        UserInfos[1].age = 34;

        //[3]����ü �迭 ���
        for (int i = 0; i < UserInfos.Length; i++)
        {
            PrintUserInfo(UserInfos[i].name, UserInfos[i].age);
        }

    }

    //���� ����� ����ϴ� �Լ�
    void PrintUserInfo(string name, int age)
    {
        
        Debug.Log($"{name}���� ���̴�{age}�� �Դϴ�");
    }
 
    void PrintUserInfo(UserInfo userinfo)
    {
        Debug.Log($"{userinfo.name}���� ���̴� {userinfo.age}�Դϴ�");
    }

}
