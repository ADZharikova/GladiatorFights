using System;

namespace GladiatorFights
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Warrior[] fighter1 = new Warrior[5] {new Knight(random), new Barbarian(random), new Magician(random), new Alchemist(random), new Churcher(random) };
            Warrior[] fighter2 = new Warrior[5] { new Knight(random), new Barbarian(random), new Magician(random), new Alchemist(random), new Churcher(random) };
            var isFight = true;
            int tryFighter = -1;
            bool b;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Добро пожаловать на гладиаторские бои в Средневековье в Европе!!!");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nВыберете своего бойца:\n1. Рыцарь.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("После того, как его здоровье становиться меньше 70, с каждым ходом оно увеличивается на 7, но не больше 70.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2. Барбариан.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Немного меньше жизней, но после 4 хода у него увиличивается ярость, и все его удары становятся сильнее в 2 раза.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("3. Маг.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Во время 5 хода он призывает молнию, которая сносит 30 единиц здоровья врагу.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("4. Алхимик.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("После 4 удара изменяет материал своей брони и улучшает её в 2 раза.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("5. Церковник.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("После того, как жизней становиться меньше 50, он молится и у него ещё накидывается 70 жизней.\n");
            
            Console.WriteLine("Укажите его номер.");
            Console.ResetColor();
            
            while (tryFighter < 0 || tryFighter > 5)
            {
                Console.Write("Ваш выбор: ");
                var putUser = Console.ReadLine().Trim();
                b = Int32.TryParse(putUser, out int result);
                {
                    if (b && result > 0 && result <= 5)
                    {
                        tryFighter = result;
                    }
                    else
                    {
                        Console.WriteLine("Укажите значение ещё раз.");
                    }
                }
                
            }
            var enemy = random.Next(0, 5);
            Console.WriteLine("Ваш враг: " + (enemy + 1));
            Console.WriteLine();

            while (isFight)
            {
                fighter1[tryFighter - 1].ShowInfo();
                fighter2[enemy].ShowInfo();
                fighter1[tryFighter - 1].TakeDamage(fighter2[enemy].Damage);
                fighter2[enemy].TakeDamage(fighter1[tryFighter - 1].Damage);

                if (fighter2[enemy].IsFight == false)
                {
                    Console.WriteLine();
                    fighter1[tryFighter - 1].ShowInfo();
                    fighter2[enemy].ShowInfo();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\nВторой проиграл.");
                    isFight = false;
                }

                else if (fighter1[tryFighter - 1].IsFight == false)
                {
                    Console.WriteLine();
                    fighter1[tryFighter - 1].ShowInfo();
                    fighter2[enemy].ShowInfo();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\nПервый проиграл.");
                    isFight = false;
                }

                Console.ResetColor();
                fighter1[tryFighter - 1].Superpower((Knight)fighter1[0], (Barbarian)fighter1[1], (Magician)fighter1[2], (Alchemist)fighter1[3], (Churcher)fighter1[4]);
                fighter2[enemy].Superpower((Knight)fighter2[0], (Barbarian)fighter2[1], (Magician)fighter2[2], (Alchemist)fighter2[3], (Churcher)fighter2[4]);

                Console.WriteLine();                
            }
            Console.ReadKey(true);
        }
    }
}
