using UnityEngine;

public class ClassMember
{
    //[1] ����(static) �޼���
    public static void StaticMethod()
    {
        Debug.Log("����(static) �޼���");
    }
    
    //[2]�ν��Ͻ�(Instance) �޼���
    public void InstanceMethod()
    {
        Debug.Log("�ν��Ͻ�(InstanceMehod) �޼���");
    }
}
