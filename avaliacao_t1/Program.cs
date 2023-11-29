using Semana4.AvaliacaoT1;
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

Doctor doctor1 = new Doctor("Dr. João", new DateTime(1980, 5, 15), "12345678901", "CRM12345");
Doctor doctor2 = new Doctor("Dra. Maria", new DateTime(1975, 8, 22), "23456789012", "CRM67890");
Doctor doctor3 = new Doctor("Dr. Carlos", new DateTime(1990, 3, 10), "45678901234", "CRM54321");
List<Doctor> doctorList = new List<Doctor>();
doctorList.Add(doctor1);
doctorList.Add(doctor2);
doctorList.Add(doctor3);

List<string> sintomas1 = new List<string> { "Febre", "Tosse" };
List<string> sintomas2 = new List<string> { "Coceira", "pigarro" };
List<string> sintomas3 = new List<string> { "Dor de cabeça", "incomodo nas costas" };
List<string> sintomas4 = new List<string> {};

Patient patient1 = new Patient("Valber", new DateTime(1996, 6, 19), "07109001555", "masculino", sintomas1);
Patient patient2 = new Patient("Joao", new DateTime(1999, 7, 22), "12345678912", "masculino", sintomas3);
Patient patient3 = new Patient("Zaca", new DateTime(1997, 6, 19), "98765432121", "feminino", sintomas2);
Patient patient4 = new Patient("Joana", new DateTime(1997, 6, 19), "11223344551", "feminino", sintomas4);

List<Patient> patientList = new List<Patient>();
patientList.Add(patient1);
patientList.Add(patient2);
patientList.Add(patient3);
patientList.Add(patient4);

var report1 = doctorList.Where(doctor => doctor.Age >= 30 && doctor.Age <= 45);
var report2 = patientList.Where(patient => patient.Age >= 25 && patient.Age <= 30);
var report3 = patientList.Where(patient => patient.Gender == "masculino" );
var report4 = patientList.OrderBy(patient => patient.Name );
var report5 = patientList.Where(patient => patient.Symptoms.Count > 0);
var report6 = patientList.Where(patient => patient.BirthDate.Month == 6);
var report7 = doctorList.Where(doctor => doctor.BirthDate.Month == 6);

Console.WriteLine($"Relatório 1: Médicos com idade entre {30} e {45} anos");

foreach (var doctor in report1)
{
    Console.WriteLine($"Nome do médico: {doctor.Name} - Idade: {doctor.Age} - CPF: {doctor.Cpf} - CRM: {doctor.Crm}");
}

Console.WriteLine($"Relatório 2: Pacientes com idade entre {25} e {30} anos");

foreach (var patient in report2)
{
    Console.WriteLine($"Nome do paciente: {patient.Name} - Idade: {patient.Age} - CPF: {patient.Cpf}");
    Console.WriteLine($"Sintomas");
    patient.Symptoms.ForEach(s => Console.WriteLine(s));
    Console.WriteLine($"\n");
}

Console.WriteLine($"Relatório 3: Pacientes do sexo masculino");

foreach (var patient in report3)
{
    Console.WriteLine($"Nome do paciente: {patient.Name} - Idade: {patient.Age} - CPF: {patient.Cpf}");
    Console.WriteLine($"Sintomas");
    patient.Symptoms.ForEach(s => Console.WriteLine(s));
    Console.WriteLine($"\n");
}


Console.WriteLine($"Relatório 4: Pacientes em ordem alfabética");

foreach (var patient in report4)
{
    Console.WriteLine($"Nome do paciente: {patient.Name} - Idade: {patient.Age} - CPF: {patient.Cpf}");
    Console.WriteLine($"Sintomas");
    patient.Symptoms.ForEach(s => Console.WriteLine(s));
    Console.WriteLine($"\n");
}

Console.WriteLine($"Relatório 5: Pacientes que informaram sintomas");

foreach (var patient in report5)
{
    Console.WriteLine($"Nome do paciente: {patient.Name} - Idade: {patient.Age} - CPF: {patient.Cpf}");
    Console.WriteLine($"Sintomas");
    patient.Symptoms.ForEach(s => Console.WriteLine(s));
    Console.WriteLine($"\n");
}

Console.WriteLine($"Relatório 6: Pacientes e médico que fazem aniversário em junho");

foreach (var patient in report6)
{
    Console.WriteLine($"Nome do paciente: {patient.Name} - Idade: {patient.Age} - CPF: {patient.Cpf}");
}

foreach (var doctor in report7)
{
    Console.WriteLine($"Nome do médico: {doctor.Name} - Idade: {doctor.Age} - CPF: {doctor.Cpf} - CRM: {doctor.Crm}");
}
