using System.Collections.Generic;

namespace ConsoleAppIRepository
{
    public class MySqlRepository:IRepository
    {
        private List<string> cars;
        
        public MySqlRepository()
        {
            //initialize to do
            cars = new List<string>();
        }

        public List<string> GetCars()
        {
            return new List<string>()
            {
                "Volvo",
                "Mercedes"
            };
        }

        public bool AddNewCar(string car)
        {
            cars.Add(car);
            return true;
        }
    }
}