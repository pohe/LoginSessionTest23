using LoginSessionTest.Models;

namespace LoginSessionTest.Interfaces
{
    public interface ICarService
    {

        public List<Car> GetAllCars();
        Car GetCarByRegnr(string carRegNr);
    }
}
