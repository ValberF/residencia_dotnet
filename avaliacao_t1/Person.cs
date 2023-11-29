namespace Semana4.AvaliacaoT1
{
    public abstract class Person
    {
        private static HashSet<string> cpfsUnicos = new HashSet<string>();
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Cpf { get; set; }
        public Person(string _name, string _birthDate, string _cpf)
        {
            Name = _name;
            BirthDate = _birthDate;

            if (!cpfsUnicos.Add(_cpf))
            {
                throw new ArgumentException("CPF deve ser único.");
            }

            Cpf = _cpf;
        }
        public int Age => calculateAge(BirthDate);

        public static int calculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                age--;
            return age;
        }
    }
}