namespace Semana4.AvaliacaoT1
{
    public abstract class Person
    {
        private static HashSet<string> cpfsUnicos = new HashSet<string>();
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Cpf { get; set; }
        public Person(string _name, DateTime _birthDate, string _cpf)
        {
            Name = _name;
            BirthDate = _birthDate;

            if (cpfsUnicos.Add(_cpf))
            {
                if (ValidateCpf(_cpf))
                {
                    Cpf = _cpf;
                }
                else
                {
                    throw new ArgumentException("O CPF deve conter exatamente 11 dígitos numéricos.");

                }
            }
            else
            {
                throw new ArgumentException("CPF deve ser único.");
            }
        }
        public int Age => calculateAge(BirthDate);

        public static int calculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                age--;
            return age;
        }

        private bool ValidateCpf(string cpf)
        {
            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }
    }
}