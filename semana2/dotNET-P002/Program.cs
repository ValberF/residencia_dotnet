List<string> tasks = new List<string>();
List<string> completedTasks = new List<string>();
List<string> pendingTasks = new List<string>();

while (true)
{
    Console.WriteLine("Escolha a opção:");
    Console.WriteLine("1. Criar tarefa");
    Console.WriteLine("2. Listar tarefas");
    Console.WriteLine("3. Concluir tarefa");
    Console.WriteLine("4. Listar tarefas concluídas");
    Console.WriteLine("5. Listar tarefas pendentes");
    Console.WriteLine("6. Excluir tarefa");
    Console.WriteLine("7. Buscar tarefa por palavra-chave");
    Console.WriteLine("8. Estatística de tarefas");

    int.TryParse(Console.ReadLine(), out int option);

    switch (option)
    {
        case 1:
            Console.WriteLine("Título da tarefa:");
            string? inputTitle = Console.ReadLine();
            Console.WriteLine("Descrição da tarefa:");
            string? inputDescription = Console.ReadLine();
            Console.WriteLine("Vencimento da tarefa:");
            string? dueDate = Console.ReadLine();
            DateTime currentDate = DateTime.Now;

            if (DateTime.TryParseExact(dueDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                tasks.Add($"Criada em: {currentDate.ToString("dd/MM/yyyy HH:mm:ss")} | Vence em: {date.ToString("dd/MM/yyyy")} | {inputTitle} - {inputDescription} []\n");
                pendingTasks.Add($"Criada em: {currentDate.ToString("dd/MM/yyyy HH:mm:ss")} | Vence em: {date.ToString("dd/MM/yyyy")} | {inputTitle} - {inputDescription} []\n");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Certifique-se de digitar uma data válida no formato dd/mm/yyyy.");
            }

            break;
        case 2:
            if (tasks.Count <= 0)
            {
                Console.WriteLine("Sem tarefas criadas!");

            }
            else
            {
                foreach (string task in tasks)
                {
                    Console.WriteLine(task);
                }
            }
            break;
        case 3:
            Console.WriteLine("Qual tarefa deseja concluir?");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i} - {tasks[i]}");
            }

            int.TryParse(Console.ReadLine(), out int indexTask);

            for (int i = 0; i < pendingTasks.Count; i++)
            {
                if (pendingTasks[i] == tasks[indexTask])
                {
                    pendingTasks.RemoveAt(i);
                }
            }

            tasks[indexTask] = tasks[indexTask].Replace("[]", "[x]");
            completedTasks.Add(tasks[indexTask]);
            break;
        case 4:
            if (completedTasks.Count <= 0)
            {
                Console.WriteLine("Sem tarefas concluídas!");

            }
            else
            {
                foreach (string task in completedTasks)
                {
                    Console.WriteLine(task);
                }
            }
            break;
        case 5:
            if (pendingTasks.Count <= 0)
            {
                Console.WriteLine("Sem tarefas pendentes!");

            }
            else
            {
                foreach (string task in pendingTasks)
                {
                    Console.WriteLine(task);
                }
            }
            break;
        case 6:
            Console.WriteLine("Qual tarefa deseja excluir?");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i} - {tasks[i]}");
            }

            int.TryParse(Console.ReadLine(), out int index);
            tasks.RemoveAt(index);
            break;
        case 7:
            if (tasks.Count <= 0)
            {
                Console.WriteLine("Sem tarefas criadas!");

            }
            else
            {
                Console.WriteLine("Qual a palavra-chave da tarefa que deseja buscar?");
                string? input = Console.ReadLine();

                foreach (string task in tasks)
                {
                    if (task.Contains(input))
                    {
                        Console.WriteLine(task);
                    }
                }
            }
            break;
        case 8:
            Console.WriteLine("Estatísticas de tarefas: \n");
            Console.WriteLine($"Tarefas concluídas: {completedTasks.Count} \n");
            Console.WriteLine($"Tarefas pendentes: {pendingTasks.Count} \n");

            DateTime olderDate = DateTime.Parse(tasks[0].Substring(11, 19));
            DateTime newestDate = DateTime.Parse(tasks[0].Substring(11, 19));
            string olderTask = tasks[0];
            string newestTask = tasks[0];

            foreach (string task in tasks)
            {
                if (olderDate > DateTime.Parse(task.Substring(11, 19)))
                {
                    olderDate = DateTime.Parse(task.Substring(11, 19));
                    olderTask = task;
                }
            }

            Console.WriteLine($"Tarefa mais antiga: {olderTask}\n");

            foreach (string task in tasks)
            {
                if (newestDate < DateTime.Parse(task.Substring(11, 19)))
                {
                    newestDate = DateTime.Parse(task.Substring(11, 19));
                    newestTask = task;
                }
            }

            Console.WriteLine($"Tarefa mais nova: {newestTask}\n");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
