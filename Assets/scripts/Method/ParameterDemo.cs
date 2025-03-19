using Constructor;
using UnityEngine;
namespace Method
{
    public class ParameterDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //몬스터 생성
            Monster monster1 = new Monster(100,15);
            Monster.monsterCount++;
            Monster monster2 = new Monster(120, 9);
            Monster.monsterCount++;

            //전투
            //MonsterBattle(monster2, monster1);
            monster1.TakeDamage(monster2.attack);
            monster2.TakeDamage(monster1.attack);

            Debug.Log($"monster1 hp : {monster1.HP} , attack : {monster1.attack}");
            Debug.Log($"monster2 hp : {monster2.HP} , attack : {monster2.attack}");
            Debug.Log($"몬스터 총 합 {Monster.monsterCount}");
        }

        //몬스터간의 1:1 전투 구현 : 
        
        void MonsterBattle(Monster atkMonster, Monster defMonster)
        {
            defMonster.HP -= atkMonster.attack;
        }
    }

    //몬스터를 관리하는 클래스
    public class Monster
    {
        //필드
        //정적 멤버 변수 : 이 프로젝트 내에서 단 하나만 존재하는 값 , 공유(Share)의 개념도 있다
        //이 게임에서 생성된 모스터 총 수량을 저장
        public static int monsterCount = 0;

        //전역 변수
        public int HP;
        public int attack;

        //생성자
        public Monster(int hp , int attack)
        {
            this.HP = hp;
            this.attack = attack;
        }
        
        //데미지를 입는 함수
        public void TakeDamage(/*Monster _this,*/ int damage)
        {
            this.HP -= damage;
        }

    }
}