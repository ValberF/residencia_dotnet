/*#region foreach
string[] colecao = {"Item1", "Item2", "Item3", "Item4"};

foreach (string item in colecao) {
    Console.WriteLine(item);
}
#endregion

#region ReadLine exemple

Console.WriteLine("Please enter your name: ");
string? name = Console.ReadLine();
Console.WriteLine($"Hello, {name}");

#endregion

#region Print 3 and 4 divisors

for (int i = 0; i <= 30; i++) {
    if(i % 3 == 0 || i % 4 == 0) {
        Console.WriteLine(i);
    }
}

#endregion */

#region fibonacci

int previous = 0, actual = 1, fib = 0;

Console.WriteLine(previous);
Console.WriteLine(actual);
while (fib < 100) {
    fib = previous + actual;
    Console.WriteLine(fib);
    previous = actual;
    actual = fib;
}

#endregion


#region table



#endregion