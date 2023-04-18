using System;

namespace EnforceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int enforceStack = 0;
            int gold = 5000000;

            Console.WriteLine("확률강화 게임을 시작합니다");
            Console.WriteLine("강화비용은 각 단계마다 상이하며 처음엔 500만 골드가 주어집니다");
            Console.WriteLine("바로 강화를 시작해봅시다!");
            

            while (true)
            {
                Console.WriteLine("[1] 강화 시도하기");
                Console.WriteLine("[2] 강화 확률 보기");
                Console.WriteLine("[3] 현재 나의 강화단계 보기");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        enforceStack = EnforceTry(enforceStack, ref gold);
                        break;
                    case "2":
                        EnforcePercentagecheck();
                        break;
                    case "3":
                        CheckEnforceStack(enforceStack);
                        break;
                }
            }
        }
        static void CheckEnforceCost(ref int gold, int enforceStack)
        {

        }
        static void CheckEnforceStack(int enforceStack)
        {
            Console.WriteLine($"현재 강화단계: {enforceStack}");
        }
        static void EnforcePercentagecheck()
        {
            Console.WriteLine("강화확률");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1 ~ 4강: 100%");
            Console.WriteLine("5 ~ 7강: 75%");
            Console.WriteLine("8강: 65%");
            Console.WriteLine("9강: 60%");
            Console.WriteLine("10강: 50%");
            Console.WriteLine("11강: 40%");
            Console.WriteLine("12강: 20%");
            Console.WriteLine("13강: 15%");
            Console.WriteLine("14강: 9%");
            Console.WriteLine("15강: 5%");
            Console.WriteLine("16강: 4%");
            Console.WriteLine("17강: 3%");
            Console.WriteLine("18강: 2%");
            Console.WriteLine("19강: 1%");
            Console.WriteLine("--------------------------------------------");
        }
        static int EnforceTry(int enforceStack, ref int gold)
        {
            if (enforceStack == 0 || enforceStack == 1 || enforceStack == 2 || enforceStack == 3 && gold >= 10000)
            {
                Console.WriteLine("강화가 성공하였습니다!");
                enforceStack++;
                Console.WriteLine($"현재는 {enforceStack}강 입니다!");
                gold -= 10000;
            }

            else if (enforceStack == 4 || enforceStack == 5 || enforceStack == 6 && gold >= 50000)
            {
                Random random = new Random();
                int randomStack = random.Next(0, 101);

                if (randomStack <= 75)
                {
                    Console.WriteLine("강화가 성공하였습니다!");
                    enforceStack++;
                    Console.WriteLine($"현재는 {enforceStack}강 입니다!");
                }
                else
                {
                    enforceStack--;
                    Console.WriteLine($"강화에 실패하여 {enforceStack}강 입니다");
                }

                gold -= 50000;
            }

            else if (enforceStack == 7 && gold >= 100000)
            {
                Random random = new Random();
                int randomStack = random.Next(0, 101);

                if (randomStack <= 65)
                {
                    Console.WriteLine("강화가 성공하였습니다!");
                    enforceStack++;
                    Console.WriteLine($"현재는 {enforceStack}강 입니다!");
                }
                else
                {
                    enforceStack--;
                    Console.WriteLine($"강화에 실패하여 {enforceStack}강 입니다");
                }

                gold -= 100000;
            }

            else if (enforceStack == 8 && gold >= 120000)
            {
                Random random = new Random();
                int randomStack = random.Next(0, 101);

                if (randomStack <= 60)
                {
                    Console.WriteLine("강화가 성공하였습니다!");
                    enforceStack++;
                    Console.WriteLine($"현재는 {enforceStack}강 입니다!");
                }
                else
                {
                    enforceStack--;
                    Console.WriteLine($"강화에 실패하여 {enforceStack}강 입니다");
                }

                gold -= 120000;
            }

            else if (enforceStack == 9 && gold >= 140000)
            {
                Random random = new Random();
                int randomStack = random.Next(0, 101);

                if (randomStack <= 50)
                {
                    Console.WriteLine("강화가 성공하였습니다!");
                    Console.WriteLine("10강 부터는 강화 실패 시 강화단계가 초기화 됩니다.");
                    enforceStack++;
                    Console.WriteLine($"현재는 {enforceStack}강 입니다!");
                }
                else
                {
                    enforceStack--;
                    Console.WriteLine($"강화에 실패하여 {enforceStack}강 입니다");
                }

                gold -= 140000;
            }

            else if (enforceStack == 10 && gold >= 150000)
            {
                Random random = new Random();
                int randomStack = random.Next(0, 101);

                if (randomStack <= 40)
                {
                    Console.WriteLine("강화가 성공하였습니다!");
                    enforceStack++;
                    Console.WriteLine($"현재는 {enforceStack}강 입니다!");
                }
                else
                {
                    enforceStack = 0;
                    Console.WriteLine($"강화에 실패하여 {enforceStack}강 입니다");
                }

                gold -= 150000;
            }

            else if (enforceStack == 11 && gold >= 200000)
            {
                Random random = new Random();
                int randomStack = random.Next(0, 101);

                if (randomStack <= 20)
                {
                    Console.WriteLine("강화가 성공하였습니다!");
                    enforceStack++;
                    Console.WriteLine($"현재는 {enforceStack}강 입니다!");
                }
                else
                {
                    enforceStack = 0;
                    Console.WriteLine($"강화에 실패하여 {enforceStack}강 입니다");
                }

                gold -= 200000;
            }

            else if (enforceStack == 12 && gold >= 250000)
            {
                Random random = new Random();
                int randomStack = random.Next(0, 101);

                if (randomStack <= 15)
                {
                    Console.WriteLine("강화가 성공하였습니다!");
                    enforceStack++;
                    Console.WriteLine($"현재는 {enforceStack}강 입니다!");
                }
                else
                {
                    enforceStack = 0;
                    Console.WriteLine($"강화에 실패하여 {enforceStack}강 입니다");
                }

                gold -= 250000;
            }

            else if (enforceStack == 13 && gold >= 300000)
            {
                Random random = new Random();
                int randomStack = random.Next(0, 101);

                if (randomStack <= 9)
                {
                    Console.WriteLine("강화가 성공하였습니다!");
                    enforceStack++;
                    Console.WriteLine($"현재는 {enforceStack}강 입니다!");
                }
                else
                {
                    enforceStack = 0;
                    Console.WriteLine($"강화에 실패하여 {enforceStack}강 입니다");
                }

                gold -= 300000;
            }

            else if (enforceStack == 14 && gold >= 400000)
            {
                Random random = new Random();
                int randomStack = random.Next(0, 101);

                if (randomStack <= 5)
                {
                    Console.WriteLine("강화가 성공하였습니다!");
                    enforceStack++;
                    Console.WriteLine($"현재는 {enforceStack}강 입니다!");
                }
                else
                {
                    enforceStack = 0;
                    Console.WriteLine($"강화에 실패하여 {enforceStack}강 입니다");
                }

                gold -= 400000;
            }

            else if (enforceStack == 15 && gold >= 500000)
            {
                Random random = new Random();
                int randomStack = random.Next(0, 101);

                if (randomStack <= 4)
                {
                    Console.WriteLine("강화가 성공하였습니다!");
                    enforceStack++;
                    Console.WriteLine($"현재는 {enforceStack}강 입니다!");
                }
                else
                {
                    enforceStack = 0;
                    Console.WriteLine($"강화에 실패하여 {enforceStack}강 입니다");
                }

                gold -= 500000;
            }

            else if (enforceStack == 16 && gold >= 600000)
            {
                Random random = new Random();
                int randomStack = random.Next(0, 101);

                if (randomStack <= 4)
                {
                    Console.WriteLine("강화가 성공하였습니다!");
                    enforceStack++;
                    Console.WriteLine($"현재는 {enforceStack}강 입니다!");
                }
                else
                {
                    enforceStack = 0;
                    Console.WriteLine($"강화에 실패하여 {enforceStack}강 입니다");
                }

                gold -= 600000;
            }

            else if (enforceStack == 17 && gold >= 700000)
            {
                Random random = new Random();
                int randomStack = random.Next(0, 101);

                if (randomStack <= 3)
                {
                    Console.WriteLine("강화가 성공하였습니다!");
                    enforceStack++;
                    Console.WriteLine($"현재는 {enforceStack}강 입니다!");
                }
                else
                {
                    enforceStack = 0;
                    Console.WriteLine($"강화에 실패하여 {enforceStack}강 입니다");
                }

                gold -= 700000;
            }

            else if (enforceStack == 18 && gold >= 800000)
            {
                Random random = new Random();
                int randomStack = random.Next(0, 101);

                if (randomStack <= 2)
                {
                    Console.WriteLine("강화가 성공하였습니다!");
                    enforceStack++;
                    Console.WriteLine($"현재는 {enforceStack}강 입니다!");
                }
                else
                {
                    enforceStack = 0;
                    Console.WriteLine($"강화에 실패하여 {enforceStack}강 입니다");
                }

                gold -= 800000;
            }

            else if (enforceStack == 19 && gold >= 1000000)
            {
                Random random = new Random();
                int randomStack = random.Next(0, 101);

                if (randomStack <= 1)
                {
                    Console.WriteLine("강화가 성공하였습니다!");
                    enforceStack++;
                    Console.WriteLine($"현재는 {enforceStack}강 입니다.");
                }
                else
                {
                    enforceStack = 0;
                    Console.WriteLine($"강화에 실패하여 {enforceStack}강 입니다");
                }

                gold -= 1000000;
            }

            else
            {
                Console.WriteLine("골드가 부족합니다!");
                Console.WriteLine($"현재 가진 골드: {gold}");
            }

            Console.WriteLine($"현재 가진 골드: {gold}");

            

            return enforceStack;
        }
    }
}