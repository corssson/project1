using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string a = "Агния Барто";
            Console.WriteLine(a);
            Console.ForegroundColor = ConsoleColor.Blue;
            string b = "ОСЕННЯЯ ПЕСЕНКА";
            Console.WriteLine(b);
            Console.ForegroundColor = ConsoleColor.Red;
            string c = "Миновало лето, Осень наступила. \nНа полях и в рощах Пусто и уныло. \nПтички улетели, Стали дни короче, \nСолнышка не видно, Темны, темны ночи.";
            Console.WriteLine(c);
            Console.ResetColor();
        }
    }
}
