#region Q3 - conversao de tipos de dados
double val = 2.32, auxVal;
int valConvert = (int)val;

Console.WriteLine("Sem considerar a parte fracionária.");
Console.WriteLine(valConvert);

auxVal = Math.Floor(val);
valConvert = (int)auxVal;
Console.WriteLine("Considerando a parte fracionária utilizando o piso.");
Console.WriteLine(valConvert);

auxVal = Math.Ceiling(val);
valConvert = (int)auxVal;
Console.WriteLine("Considerando a parte fracionária utilizando o teto.");
Console.WriteLine(valConvert);
#endregion

#region Q4 - operadores aritmeticos
int x = 10, y = 3;

Console.WriteLine($"Soma de {x} e {y} é {x + y}");
Console.WriteLine($"Subtração de {x} e {y} é {x - y}");
Console.WriteLine($"Multiplicação de {x} e {y} é {x * y}");
Console.WriteLine($"Divisão de {x} e {y} é {x / y}");
#endregion

#region Q5 - operadores de comparacao
int a = 5, b = 8;

if (a > b)
{
    Console.WriteLine("A é maior que B!");
}
else
{
    Console.WriteLine("A é menor que B!");
}
#endregion

#region Q6 - operadores de igualdade
string str1 = "Hello", str2 = "World";

if (str1 == str2)
{
    Console.WriteLine("A strings são iguais!");
}
else
{
    Console.WriteLine("A strings são diferentes!");
}
#endregion

#region Q7 - operadores logicos
bool condicao1 = true, condicao2 = false;

if (condicao1 && condicao2)
{
    Console.WriteLine("As duas condições são verdadeiras!");
}
else
{
    Console.WriteLine("Pelo menos umas das duas condições é falsa!");
}
#endregion

#region Q8 - desafio mistura de operadores
int num1 = 7, num2 = 3, num3 = 10;

if (num1 > num2)
{
    Console.WriteLine($"Num1 ({num1}) é maior");
}
else
{
    Console.WriteLine($"Num2 ({num2}) é maior");
}

if (num3 == num1 + num2)
{
    Console.WriteLine($"Num3 ({num3}) é igual a Num1 + Num2 ({num1 + num2})");
}
else
{
    Console.WriteLine($"Num3 ({num3}) é diferente a Num1 + Num2 ({num1 + num2})");
}
#endregion
