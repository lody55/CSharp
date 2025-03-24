using UnityEngine;
namespace Override
{
    //플레이어(....) , 몬스터(슬라임, 좀비 , 고블린 ....등등)
    //모든 캐릭터의 (추상클래스) 부모 클래스 (캐릭터들이 가지고 있는 공통기능)
    public abstract class Character
    {
        public abstract int GetTotalAttack();

        public int health;
        public int baseAtk;

        //생성자  - 멤버초기화
        public Character(int hp, int atk)
        {
            this.health = hp;
            this.baseAtk = atk;
        }

        //캐릭터의 health 그리기 
        public void DrawHealth(Character ch)
        {
            Debug.Log($"{ch} : {ch.health}");
        }

        //매개변수로 나에게 데미지 주는 캐릭터 객체를 전달해준다
        public void TakeDamage(Character other)
        {
            health -= other.GetTotalAttack();
        }
    }

    //플레이어
    public class Player : Character
    {
        public Player() : this(100,20) { }
        public Player(int hp, int atk) : base(hp, atk) { }

        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //장비 , 스킬 , 상성 등 영향미치는 것들 누적

            return total;
        }
    }
    //몬스터(슬라임 , 좀비 , 고블린 ......등의 부모클래스)
    public class Monster : Character
    {
        public Monster(int hp, int atk) : base(hp, atk) { }

        //
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            return total;
        }

        //슬라임 , 좀비 , 고블린....등의 공통 기능 구현
        
    }
    //고블린
    public class Goblin : Monster
    {
        //고블린만에 특성
        public int posX, posY;
        public Goblin() : this(80, 15) { }
        //생성자
        public Goblin(int hp, int atk) : base(hp, atk) { }
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            return total;
        }
        public void SetPosition(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }
       
    }
    public class Skeleton:Monster
    {
        public Skeleton() : this(90, 8) { }
        public Skeleton(int hp, int atk) : base(hp, atk) { }
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            return total;
        }
        //스킬
        //상성....
    }
    public class Zombie : Monster
    {
        public Zombie() : this(45, 20) { }
        public Zombie(int hp, int atk) : base(hp, atk) { }
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            return total;
        }
        //스킬
        //상성....


    }
}