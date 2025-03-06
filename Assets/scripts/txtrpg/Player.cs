using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    static int playerHP = 100;  // 플레이어 체력
    static int playerATK = 20;  // 플레이어 공격력
    static int playerDEF = 5;   // 플레이어 방어력

    static int monsterHP = 80;  // 몬스터 체력
    static int monsterATK = 15; // 몬스터 공격력

    static void Main()
    {
        Console.WriteLine("🌟 텍스트 RPG 게임 시작! 🌟");
        Console.WriteLine("당신은 강력한 몬스터와 싸우게 됩니다!");
        Console.WriteLine("===================================");

        while (playerHP > 0 && monsterHP > 0)
        {
            PlayerTurn();
            if (monsterHP <= 0) break;
            MonsterTurn();
        }

        if (playerHP > 0)
            Console.WriteLine("\n🎉 승리했습니다! 🎉");
        else
            Console.WriteLine("\n💀 패배했습니다... 💀");

        Console.WriteLine("게임 종료!");
    }

    static void PlayerTurn()
    {
        Console.WriteLine("\n⚔️ [당신의 턴!] ⚔️");
        Console.WriteLine($"(1) 공격하기    (2) 방어하기");
        Console.Write("👉 선택: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            int damage = playerATK;  // 고정된 데미지 (랜덤 X)
            Console.WriteLine($"💥 몬스터에게 {damage}의 데미지를 입혔다!");
            monsterHP -= damage;
        }
        else if (choice == "2")
        {
            playerDEF += 5;  // 방어력 증가
            Console.WriteLine("🛡️ 방어 자세를 취했다! (방어력 +5)");
        }

        Console.WriteLine($"👹 [몬스터 HP] {monsterHP}");
    }

    static void MonsterTurn()
    {
        Console.WriteLine("\n👹 [몬스터의 턴!] 👹");

        int damage = Math.Max(0, monsterATK - playerDEF);  // 방어력 적용 후 고정된 데미지
        Console.WriteLine($"💥 몬스터가 {damage}의 데미지를 입혔다!");
        playerHP -= damage;

        Console.WriteLine($"🧑‍🚀 [플레이어 HP] {playerHP}");
    }
}















