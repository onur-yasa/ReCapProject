using DateAccess.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear="2021",DailyPrice=250,Description="2 gün kiralanacak",CarName="Bmv"},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear="2020",DailyPrice=250,Description="2 gün kiralanacak",CarName="Merdedes"},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear="2020",DailyPrice=250,Description="2 gün kiralanacak",CarName="Duster"},
                new Car{Id=2,BrandId=2,ColorId=3,ModelYear="2018",DailyPrice=250,Description="2 gün kiralanacak",CarName="Audi"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("New Car is added");
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

        public List<Car> GeyById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

       
    }
}
