namespace RefactoringToPatterns.CreationMethods.Before
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public bool IsElectric { get; set; }

        public Vehicle(string make, string model, int year, string color) : this(make, model, year, color, 0)
        {
        }
        public Vehicle(string make, string model, int year, string color, int mileage) : this(make, model, year, color, 0, false)
        {
        }
        public Vehicle(string make, string model, int year, string color, int mileage, bool isElectric)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Mileage = mileage;
            IsElectric = isElectric;
        }
    }
}
