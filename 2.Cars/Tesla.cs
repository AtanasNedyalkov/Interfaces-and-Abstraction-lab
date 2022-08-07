namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int Batteries { get; private set; }
        public Tesla(string model, string color, int batteries)
        {
            this.Model = model;
            this.Color = color;
            this.Batteries = batteries;
        }
        public string Start()
        {
            return $"Engine start";
        }
        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            //Red Tesla Model 3 with 2 Batteries
            return $"{this.Color} {this.GetType().Name} {this.Model} with {this.Batteries} {nameof(this.Batteries)}";
        }


    }
}