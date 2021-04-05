using System;
using System.Collections.Generic;

namespace ConsoleAppIRepository
{
    public interface IRepository
    {
        List<String> GetCars();
        bool AddNewCar(string car);
    }
}