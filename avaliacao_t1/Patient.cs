namespace Semana4.AvaliacaoT1
{
    public class Patient : Person
    {
        public string gender { get; set; }
        public List<string> Symptom { get; set; }

        public Patient(string _gender, List<string> _symptoms)
        {
            Gender = gender;
            Symptoms = _symptoms;
        }
    }
}