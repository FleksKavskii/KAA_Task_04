using System;

namespace KAA_Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int bossHp = rnd.Next(100, 200);
            int heroHp = rnd.Next(100, 200);
            int turn = rnd.Next(1, 2);
            int tact = 1;
            string spell;
            bool die = true;
            int lightning = 50;
            Console.WriteLine("Игра - победи Босса");
            Console.WriteLine("Условия");
            Console.WriteLine("Случайным образом выбирается игрок, делающий первый ход");
            Console.WriteLine("Величина урона, наносимого Боссом, для каждого хода случайна");
            Console.WriteLine("Игрок может пользоваться следующими заклинаниями: ");
            Console.WriteLine();
            Console.WriteLine("лайтинг - атака, урон от 50 единиц");
            Console.WriteLine("рекавери - Восстановление ХП 50 единиц");
            Console.WriteLine("слипинг - Босс пропускает следующий ход");
            Console.WriteLine("буст - высасывает 20 ХП Босса и восстанвливает 20 ХП герою");
            Console.WriteLine("дисванг - Игрок пропускает ход, но при пробуждении атака от первого заклинание увеличивается на 30 единиц");
            Console.WriteLine($"ХП Босса - {bossHp}");
            Console.WriteLine($"ХП Героя - {heroHp}");
            Console.WriteLine();
            
            while (die)
            {
                Console.WriteLine($"Игровой такт №{tact}");
                if (turn == 1)
                {
                    turn += 1;
                    tact += 1;
                    Console.WriteLine("Атакует игрок");
                    Console.Write("Введите заклинание- ");
                    spell = Console.ReadLine();
                    if (spell == "лайтинг")
                        bossHp -= lightning;
                    if (spell == "рекавери")
                        heroHp += 50;
                    if (spell == "слипинг")
                        turn = 1;
                    if (spell == "буст")
                    {
                        bossHp -= 30;
                        heroHp += 30;
                    }
                    if (spell == "дисванг")
                        lightning += 30;
                    Console.WriteLine($"ХП Босса - {bossHp}");
                    Console.WriteLine($"ХП Героя - {heroHp}");
                    if (heroHp <= 0)
                        die = false;
                    Console.WriteLine();
                }
                if (turn == 2)
                {
                    Console.WriteLine($"Игровой такт №{tact}");
                    turn -= 1;
                    tact += 1;
                    Console.WriteLine("Атакует Босс");
                    int attack = rnd.Next(40, 70);
                    heroHp -= attack;
                    Console.WriteLine($"ХП Босса - {bossHp}");
                    Console.WriteLine($"ХП Героя - {heroHp}");
                    if (bossHp <= 0)
                        die = false;
                    Console.WriteLine();
                }



            }
            
            if (heroHp <= 0)
                Console.WriteLine("Вы проиграли");
            if (bossHp <= 0)
                Console.WriteLine("Вы выиграли");
        }
    }
}
