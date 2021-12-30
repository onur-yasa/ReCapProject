﻿using Business.Concrete;
using DateAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.CarName);
            }
        }
    }
}