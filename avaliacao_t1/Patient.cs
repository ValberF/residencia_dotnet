namespace Semana4.AvaliacaoT1
{
    public class Patient : Person
    {
        public string gender { get; set; }
        public List<string> Symptom { get; set; }

        public Patient(string _name, string _birthDate, string _cpf, string _gender, List<string> _symptoms) : base(_name, _birthDate, _cpf)
        {
            Gender = gender;
            Symptoms = _symptoms;
        }
    }
}