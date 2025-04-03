namespace LoginSessionTest.Models
{
    public class Car
    {
        public string Regnr { get; set; }
        public string Model { get; set; }

        public User Driver { get; set; }

        public Car()
        {

        }
        public Car(string regNr, string model)
        {
            Regnr = regNr;
            Model = model;
        }

        public void AddDriver(User user)
        {
            Driver = user;
        }

        public override string ToString()
        {
            return $"Regnr  {Regnr} Model {Model} Drivername {Driver.UserName}";
        }
    }
}
