using LoginSessionTest.Data;
using LoginSessionTest.Interfaces;
using LoginSessionTest.Models;

namespace LoginSessionTest.Services
{
    public class CarService : ICarService
    {
        public List<Car> GetAllCars()
        {
            return MockData.CarData;
        }

        public Car GetCarByRegnr(string carRegNr)
        {
            return MockData.CarData.Find(c => c.Regnr == carRegNr);
        }
    }
}
