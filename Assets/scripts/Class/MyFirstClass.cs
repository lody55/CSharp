using JetBrains.Annotations;
using UnityEngine;

//���� �޼��� ȣ��, �ν��Ͻ� �޼��� ȣ�� 
public class MyFirstClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����(static) �޼��� ȣ�� : StaticMethodȣ�� >>>> ȣ�� ��� : Ŭ�����̸�.�޼����̸�()
        ClassMember.StaticMethod();
        //ClassMember.InstanceMethod(); <- �ȵȴ�

        //[2] �ν��Ͻ�(Instance) �޼��� ȣ�� - InstanceMethod() ȣ��
        // ȣ���� : Ŭ������ ��ü(��ü,Instance) ���� - (Ŭ������ ���� ����)
        // new Ű���带 �̿��Ͽ� ���ο� ��ü�� ����
        //(Ŭ�����̸�) ��ü�̸� = new Ŭ�����̸�();
        //(��ü�̸�).�޼��� �̸�
        ClassMember member = new ClassMember();
        member.InstanceMethod();
        //member.StaticMethod(); <-�ȵȴ�


    }

 
}
