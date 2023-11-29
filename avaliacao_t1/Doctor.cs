namespace Semana4.AvaliacaoT1
{
    public class Doctor : Person
    {
        public string Crm { get; set; }

        public Doctor(string _crm, string _birthDate, string _cpf)
        {
            Crm = _crm;
        }
    }
}