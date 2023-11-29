namespace Semana4.AvaliacaoT1
{
    public abstract class Person
    {
        public Person(string _name, string _birthDate, string _cpf)
        {
            Name = _name;
            BirthDate = _birthDate;
            Cpf = _cpf;
        }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Cpf { get; set; }
        public int Age => calculateAge(BirthDate); // readonly property

        public static int calculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                age--;
            return age;
        }
    }
}