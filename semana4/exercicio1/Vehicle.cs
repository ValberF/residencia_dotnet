namespace Semana4.Exercicio1
{
    public class Vehicle
    {
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }

        public Vehicle(string _model, string _year, string _color)
        {
            Model = _model;
            Year = _year;
            Color = _color;
        }
    }
}