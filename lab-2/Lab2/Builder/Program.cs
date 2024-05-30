using System;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            HeroBuilder heroBuilder = new HeroBuilder();
            CharacterDirector heroDirector = new CharacterDirector(heroBuilder);
            Character hero = heroDirector.ConstructHero();

            EnemyBuilder enemyBuilder = new EnemyBuilder();
            CharacterDirector enemyDirector = new CharacterDirector(enemyBuilder);
            Character enemy = enemyDirector.ConstructEnemy();

            Console.WriteLine("Персонаж1:");
            hero.DisplayInfo();

            Console.WriteLine("\nПерсонаж2:");
            enemy.DisplayInfo();
        }
    }
}