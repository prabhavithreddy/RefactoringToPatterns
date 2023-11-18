namespace RefactoringToPatterns.CreationMethods.After
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public bool IsElectric { get; set; }

        public Vehicle(string make, string model, int year, string color, int mileage, bool isElectric)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Mileage = mileage;
            IsElectric = isElectric;
        }

        public static Vehicle CreateBiCycle(string make, string model, int year)
        {
            return new Vehicle(make, model, year, "White", 0, false);
        }
        public static Vehicle CreateBike(string make, string model, int year, string color, int mileage)
        {
            return new Vehicle(make, model, year, color, mileage, false);
        }
        public static Vehicle CreateElectricCar(string make, string model, int year, string color, int mileage)
        {
            return new Vehicle(make, model, year, color, mileage, true);
        }
    }
}
