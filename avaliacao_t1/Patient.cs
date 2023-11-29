namespace Semana4.AvaliacaoT1
{
    public class Patient : Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Cpf { get; set; }

        public Patient(string _name, string _birthDate, string _cpf)
        {
            Name = _name;
            BirthDate = _birthDate;
            Cpf = _cpf;
        }
    }
}