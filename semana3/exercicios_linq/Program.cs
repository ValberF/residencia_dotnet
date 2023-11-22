string[] people = {"Valber", "Joao", "Zaca", "Amaral"};

char letter = 'A';

Console.WriteLine($"Pessoas com a ocorrência da letra '{letter}': {string.Join(", ", people.Where(x => x.ToLower().Contains(Char.ToLower(letter))))}");