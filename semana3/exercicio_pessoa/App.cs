namespace Semana4.ExemplosAula;
public static class App
{

    public static List<Pessoa> AddPeople()
    {
        List<Pessoa> people = new List<Pessoa>();

        string answer = "s";

        do
        {
            Console.WriteLine("Informe o nome da pessoa:");
            string name = Console.ReadLine()!;

            try
            {
                Console.WriteLine("Informe a altura da Pessoa:");
                double height = Double.Parse(Console.ReadLine())!;
                Pessoa person = new Pessoa(name, height);
                people.Add();
            }
            catch
            {
                Console.WriteLine("Altura inválida!");
                continue;
            }
            finally
            {
                Console.WriteLine("Deseja continuar? (s/n)");
                answer = Console.ReadLine()!;
            }


        } while (answer.ToLower() == "s");

        return people;
    }
}