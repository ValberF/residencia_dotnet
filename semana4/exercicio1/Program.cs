using Semana4.Exercicio1;
using System.Globalization;

class Program {
    public static void Main(string[] args) {
        CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

        Vehicle carro = new Vehicle("Ford", "2002", "Prata");
        Console.WriteLine(carro.Model);
    }
}