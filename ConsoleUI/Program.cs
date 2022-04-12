using DataAccess.Concrete.InMemory;
using Entites.Concrete;
using Business.Abstract;
using Business.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
