using System;

namespace blackGame
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        };

        struct Player
        {
            public int hp;
            public int attack;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                ClassType choice = ChooseClass();
                if (choice != ClassType.None)
                {
                    // 캐릭터 생성
                    Player player;
                    CreatePlayer(choice , out player);

                    Console.WriteLine($"HP: {player.hp} Attack: {player.attack}");
                    // 기사(100/10) 궁수(75/7) 법사(50/15) 

                    // 필드로 가서 몬스터와 전투
                }
            }
        }

        static ClassType ChooseClass()
        {
            ClassType choice = ClassType.None;

            Console.WriteLine($"직업을 선택하세요!");
            Console.WriteLine($"[1] 기사");
            Console.WriteLine($"[2] 궁수");
            Console.WriteLine($"[3] 법사");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }

            return choice;
        }
        static void CreatePlayer(ClassType choice, out Player player)
        {
            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
        }
    }
}