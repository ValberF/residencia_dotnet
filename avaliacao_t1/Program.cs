using Semana4.AvaliacaoT1;
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

List<string> minhaLista = new List<string> { "Febre", "Tosse" };
Doctor doctor1 = new Doctor("Dr. João", new DateTime(1980, 5, 15), "12345678901", "CRM12345");
Doctor doctor2 = new Doctor("Dra. Maria", new DateTime(1975, 8, 22), "23456789012", "CRM67890");
Patient patient1 = new Patient("Valber", new DateTime(1996, 6, 19), "07109001555", "masculino", minhaLista);
Console.WriteLine($"{patient1.Name} - Sintomas: {patient1.Symptoms}");