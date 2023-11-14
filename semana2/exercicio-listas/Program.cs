#region strings

#endregion

#region lists

List<int> numbers = new List<int>();

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);

Console.WriteLine("List of integers");

foreach (int number in numbers) {
    Console.WriteLine(number);
}

#endregion

#region string date

string date = "25/10/2023";

string[] subDate = date.Split('/');
string day = subDate[0];
string month = subDate[1];
string year = subDate[2];

Console.WriteLine($"Dia: {day}");
Console.WriteLine($"Mês: {month}");
Console.WriteLine($"Ano: {year}");

#endregion