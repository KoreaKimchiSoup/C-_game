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
        enum MonsterType
        {
            None = 0,
            Slim = 1,
            Orc = 2,
            Skeleton = 3
        }

        struct Player
        {
            public int hp;
            public int attack;
        }

        struct Monster
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

                    // 필드로 가서 몬스터와 전투
                    EnterGame(ref player);
                }
            }
        }
        static void Fight(ref Player player, ref Monster monster)
        {
            while(true)
            {
                // 플레이어가 몬스터 공격
                monster.hp -= player.attack;
                if (monster.hp <= 0)
                {
                    Console.WriteLine("전투에서 승리하였습니다");
                    Console.WriteLine($"남은 체력: {player.hp}");
                    break;
                }

                // 몬스터 반격
                player.hp -= monster.attack;
                if (player.hp <= 0)
                {
                    Console.WriteLine("전투에서 패배하였습니다");
                    break;
                }
            }
        }
        static void CreateRandomMonster(out Monster monster)
        {
            Random random = new Random();
            int randMonster = random.Next(1, 4);

            switch (randMonster)
            {
                case (int)MonsterType.Slim:
                    Console.WriteLine("슬라임이 스폰되었습니다");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크가 스폰되었습니다");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤이 스폰되었습니다");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
            }
        }
        static void EnterField(ref Player player)
        {
            while(true)
            {
                Console.WriteLine("필드에 접속했습니다!");

                // 몬스터 생성
                Monster monster;
                // 랜덤으로 1~3 몬스터 중 하나를 리스폰
                CreateRandomMonster(out monster);

                Console.WriteLine("[1] 전투 모드로 돌입");
                Console.WriteLine("[2] 탈출 하기");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    // [1] 전투 모드로 돌입함
                    Fight(ref player, ref monster);
                }
                else if (input == "2")
                {
                    // [2] 일정 확률로 마을로 도망
                    Random random = new Random();
                    int randValue = random.Next(0, 101);
                    
                    if (randValue <= 33)
                    {
                        Console.WriteLine("도망치는데 성공했습니다.");
                    }
                    else
                    {
                        Fight(ref player, ref monster);
                    }
                }
            }
        }
        static void EnterGame(ref Player player)
        {
            while(true)
            {
                Console.WriteLine("마을에 접속했습니다.");
                Console.WriteLine("[1] 필드로 가기");
                Console.WriteLine("[2] 로비로 돌아가기");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    EnterField(ref player);
                }
                else if (input == "2")
                {
                    break;
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