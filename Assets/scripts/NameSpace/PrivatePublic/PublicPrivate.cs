using UnityEngine;
namespace PrivatePublic
{

    public class PublicPrivate
    {
        //static(정적) 필드 선언은 보통 퍼블릭으로 한다
        public static string name = "트럭";
        //필드
        private int age;
        
        //static(정적) 메서드 
        //이름을 반환하는 함수

        public static string Getname()
        {
            return name;
        }
        //private한 필드를 public한 메서드로 접근
        public void Setage(int agee)
        {
            age = agee;
        }
        public int GetAge()
        {
            return age;
        }
    }
}