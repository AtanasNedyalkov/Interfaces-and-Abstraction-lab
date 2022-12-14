namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
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
            //Grey Seat Leon
            return $"{this.Color} {this.GetType().Name} {this.Model}";
        }
    }
}
