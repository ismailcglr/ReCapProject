using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car { Id=1,BrandId=1,ColorId=1,ModelYear=2010,DailyPrice=155000,Description="FİAT PUNTO"},
                new Car { Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2004, DailyPrice = 200000, Description = "BMW E60" },
                new Car { Id = 3, BrandId = 3, ColorId = 3, ModelYear = 2019, DailyPrice = 500000, Description = "WW PASSAT" },
                new Car { Id = 4, BrandId = 4, ColorId = 4, ModelYear = 2022, DailyPrice = 1000000, Description = "AUDİ RS6" }
            };
            
        }
        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        }

        public List<Car> GetAll( )
        {
            return _cars;
        }

        public List<Car> GetById(int carId )
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car )
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
