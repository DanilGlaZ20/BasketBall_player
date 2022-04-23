using System;

namespace ConsoleApp1
{
    class BasketballPlayer
    {
// Поля этого класса
        public string Name { get; set; }
        public static int Age { get; set; }
        public static int Height { get; set; }
        public static int Weight { get; set; }
        public int Rank { get; set; }

        public static int Goal;
        private const string NameTeam = "Wolves";

        public BasketballPlayer(string name, int age, int height, int weight, int rank)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
            Rank = rank;
        }

        public BasketballPlayer()
        {
            Name = "Кирилл";
            Age = 18;
            Height = 183;
            Weight = 78;
            Rank = 4;
        }

        public BasketballPlayer(int a, int b, int c)
        {
            Age = a;
            Height = b;
            Weight = c;
        }

    
// Открытый метод результативное попадание ИЗ ПОД КОЛЬЦА
        public void ResultHit()
        {
            if (Height > 200 || Rank > 1)
            {
                Console.WriteLine("{0} попал в кольцо!", Name);
                Goal += 1;
            }
            else Console.WriteLine("{0} не попал в кольцо. {0} слишком мал.", Name);
        }

        public void Rank_Writer()
        {
            Console.WriteLine(
                "Ранг1-первый раз бросил в кольцо\nРанг2-бросал больше одного раза-занимается 1 год\nРанг3-занимается больше 1 года-до 5 лет\nРанг4-профессиональный игрок ");
        }

        public void Write()
        {
            Console.WriteLine("Имя:" + Name + "\nВозраст:" + Age + "\nРост:" + Height + "\nВес:" + Weight + "\nРанг:" +
                              Rank + "\nКлуб:" + NameTeam);
        }

//Трёха
        public void ThreePoint()
        {
            if (Rank >= 3)
            {
                this.Hit();
            }
        }

//Штрафной
        public void FreeThrow()
        {
            if (Rank >= 2 && Rank < 4)
            {
                this.Hit();
            }
            else if (Rank == 4)
            {
                Console.WriteLine("Великолепное попадание!");
                Goal += 1;
            }

            else Console.WriteLine("Мяч не долетел до кольца");
        }

//Попадание рандома
        private int Hit()
        {
            Random rand = new Random();
            int per = rand.Next(1, 3);
            if (per == 1)
            {
                Console.WriteLine("НЕ забил...");
            }
            else if (per > 1)
            {
                Console.WriteLine("УРА! Забил!");
                Goal += 1;
            }

            return per;
        }

        ~BasketballPlayer()
        {
        }

        protected int Defend()
        {
            Random rand = new Random();
            int hieght_player = rand.Next(150, 210);
            return hieght_player;
        }

//Данк
        public void Dunk()
        {
            if (Height > this.Defend())
            {
                Console.WriteLine("Забил сверху!");
                Goal += 1;
            }
            else Console.WriteLine("Не забил. Поставили блок.");
        }

//забитые мячи
        public static void N_Goal()
        {
            Console.WriteLine("Забитых мячей:" + Goal);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
// Создаём объект класса 
            BasketballPlayer plr = new BasketballPlayer("Серж", 22, 180, 85, 3);
// И используем его свойства и методы
            plr.Rank_Writer();
            plr.Write();
            plr.ResultHit();
            Console.Write("Трехочковый бросок:");
            plr.ThreePoint();
            Console.Write("Штрафной бросок:");
            plr.FreeThrow();
            plr.Dunk();
            BasketballPlayer.N_Goal();
            Console.WriteLine();


            BasketballPlayer kirill = new BasketballPlayer();
            kirill.Write();
            kirill.ResultHit();
            Console.Write("Трехочковый бросок:");
            kirill.ThreePoint();
            Console.Write("Штрафной бросок:");
            kirill.FreeThrow();
            kirill.Dunk();
            BasketballPlayer.N_Goal();
            Console.WriteLine();

            BasketballPlayer oleg = new BasketballPlayer(25, 198, 87);
            oleg.Name = "Oleg";
            oleg.Rank = 4;
            oleg.Write();
            oleg.ResultHit();
            Console.Write("Трехочковый бросок:");
            oleg.ThreePoint();
            Console.Write("Штрафной бросок:");
            oleg.FreeThrow();
            oleg.Dunk();
            BasketballPlayer.N_Goal();
        }
    }
}