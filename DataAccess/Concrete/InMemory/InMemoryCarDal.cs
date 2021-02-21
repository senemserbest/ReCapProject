using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { Id = 1, ColorId = 5, BrandId = 5, DailyPrice = 200, Description = "Dizel", ModelYear = 2017, },
                new Car { Id = 2, ColorId = 7, BrandId = 10, DailyPrice = 300, Description = "Benzin", ModelYear = 2018, },
                new Car { Id = 3, ColorId = 3, BrandId = 5, DailyPrice = 100, Description = "Benzin", ModelYear = 2016, },
                new Car { Id = 4, ColorId = 8, BrandId = 15, DailyPrice = 250, Description = "Benzin", ModelYear = 2017, },

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

      
        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        { 
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;



        }
    }
}
