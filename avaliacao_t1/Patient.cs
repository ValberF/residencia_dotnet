namespace Semana4.AvaliacaoT1
{
    public class Patient : Person
    {
        public string Gender { get; set; }
        public List<string> Symptoms { get; set; }

        public Patient(string _name, DateTime _birthDate, string _cpf, string _gender, List<string> _symptoms) : base(_name, _birthDate, _cpf)
        {
            Gender = _gender;
            Symptoms = _symptoms;
        }
    }
}