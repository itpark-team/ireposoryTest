using System.Collections.Generic;

namespace ConsoleAppIRepository
{
    public class MongoDbRepository:IRepository
    {
        private List<string> cars;

        public MongoDbRepository()
        {
            cars = new List<string>();
        }

        public List<string> GetCars()
        {
            return new List<string>()
            {
                "BMW",
                "Nissan"
            };
        }

        public bool AddNewCar(string car)
        {
            cars.Add(car);
            return false;
        }
    }
}