namespace Semana4.AvaliacaoT1
{
    public class Doctor : Person
    {
        private static HashSet<string> crmsUnicos = new HashSet<string>();

        public string Crm { get; set; }

        public Doctor(string _name, string _birthDate, string _cpf, string _crm) : base(_name, _birthDate, _cpf)
        {
            Crm = _crm;
        }
    }
}