var tuple3 = (id: 10, name: "Valber", born: new DateTime(1996, 6, 18));

Console.WriteLine($"Tuple 3: {tuple3.id}, {tuple3.name}, {tuple3.born}");

List<(int id, string name, DateTime born)> list = new();
list.Add(tuple3);
list.Add((11, "Nicole", new DateTime(2001, 9, 12)));
list.ForEach(x => Console.WriteLine($"Tuple 4: {x.id}, {x.name}, {x.born.ToShortDateString()}"));
