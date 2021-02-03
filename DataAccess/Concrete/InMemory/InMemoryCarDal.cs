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
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=1998, DailyPrice=5700, Description="Mercedes"},
                new Car{Id=2, BrandId=1, ColorId=3, ModelYear=2010, DailyPrice=20000, Description="BMW"},
                new Car{Id=3, BrandId=2, ColorId=3, ModelYear=1985, DailyPrice=28769, Description="Rolly Roys"},
                new Car{Id=4, BrandId=2, ColorId=2, ModelYear=2021, DailyPrice=34527, Description="AUDI"},
                new Car{Id=5, BrandId=3, ColorId=2, ModelYear=2000, DailyPrice=3846, Description="Toros"},
                new Car{Id=6, BrandId=4, ColorId=2, ModelYear=1978, DailyPrice=4800, Description="Reno"},
                new Car{Id=7, BrandId=5, ColorId=1, ModelYear=1998, DailyPrice=11000, Description="FORD"},
                new Car{Id=8, BrandId=5, ColorId=1, ModelYear=1965, DailyPrice=32400, Description="SCODA"},
                new Car{Id=9, BrandId=8, ColorId=2, ModelYear=1990, DailyPrice=9870, Description="Tofaş"},
                new Car{Id=10, BrandId=8, ColorId=3, ModelYear=2019, DailyPrice=15000, Description="NISSAN"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
           return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
