using UnityEngine;
namespace Override
{
    public class InheritanceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Player클래스 객체 생성
            Player player = new Player();
            //Monster클래스 객체 생성
            Goblin go = new Goblin();
            Skeleton sk = new Skeleton();
            Zombie zb = new Zombie();

            //전투
            player.TakeDamage(go);
            DrawHealth(player);
            player.TakeDamage(sk);
            DrawHealth(player); ;
            player.TakeDamage(zb);
            DrawHealth(player);

            go.TakeDamage(player);
            DrawHealth(go);
            sk.TakeDamage(player);
            DrawHealth(sk);
            zb.TakeDamage(player);
            DrawHealth(zb);

        }

        //캐릭터의 health 그리기 
        public void DrawHealth(Character ch)
        {
            Debug.Log($"{ch} : {ch.health}");
        }
        //public void DrawPlayerHealth(Player player)
        //{
        //    Debug.Log($"{player}:{player.health}");
        //}
        //public void DarwGoblinHealth(Goblin goblin)
        //{
        //    Debug.Log($"{goblin} : {goblin.health}");
        //}

    }
}