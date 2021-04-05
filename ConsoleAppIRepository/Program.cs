using System;

namespace ConsoleAppIRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository db = new MySqlRepository();

            foreach (string car in db.GetCars())
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}