namespace Semana3.dotnetP003;
public class App
{
    private List<Product> stock = new List<Product>();

    public void Menu()
    {
        while (true)
        {
            Console.WriteLine("1. Cadastro de produto");
            Console.WriteLine("2. Consulta de produto por código");
            Console.WriteLine("3. Atualizar produto");
            Console.WriteLine("4. Relatórios");
            Console.WriteLine("5. Exit");

            Console.Write("Escolha uma opção: ");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    SearchProductByCode();
                    break;
                case "3":
                    UpdateStock();
                    break;
                case "4":
                    GenerateReports();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    private void AddProduct()
    {
        try
        {
            Console.Write("Nome do produto: ");
            string? name = Console.ReadLine();

            Console.Write("Quantidade em estoque: ");
            if (int.TryParse(Console.ReadLine(), out int amount))
            {
                Console.Write("Preço unitário: ");
                if (double.TryParse(Console.ReadLine(), out double price))
                {
                    Product newProduct = new Product(name, amount, price);
                    stock.Add(newProduct);

                    Console.WriteLine("Produto adicionado!");
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número decimal válido.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro válido.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida!");
        }
    }

    private void SearchProductByCode()
    {
        try
        {
            Console.Write("Informe o código do produto: ");
            if (int.TryParse(Console.ReadLine(), out int code))
            {
                Product product = stock.FirstOrDefault(p => p.Code == code);
                if (product != null)
                {
                    Console.WriteLine($"Nome do produto: {product.Name} - Quantidade em estoque: {product.Amount}");
                }
                else
                {
                    throw new ProductNotFoundException("Produto não encontrado!");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro válido.");
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida!");
        }
        catch (ProductNotFoundException e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }
    }

    private void UpdateStock()
    {
        try
        {
            Console.Write("Informe o código do produto: ");
            if (int.TryParse(Console.ReadLine(), out int code))
            {
                Product product = stock.FirstOrDefault(p => p.Code == code);
                if (product != null)
                {
                    Console.Write("Insira a quantidade que será adicionada, números positivos para adição de estoque e negativos para venda do produto: ");
                    if (int.TryParse(Console.ReadLine(), out int amount))
                    {
                        if (product.Amount + amount < 0)
                        {
                            Console.WriteLine("Valor inválido, quantidade ficará abaixo de 0!");
                        }
                        else
                        {
                            product.Amount += amount;
                            Console.WriteLine($"{product.Name} atualizado - nova quantidade em estoque: {product.Amount}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor, insira um número inteiro válido.");
                    }

                }
                else
                {
                    throw new ProductNotFoundException("Produto não encontrado!");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro válido.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida!");
        }
        catch (ProductNotFoundException e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }
    }

    private void GenerateReports()
    {
        try
        {
            Console.Write("Informe o limite de estoque dos produtos: ");
            if (int.TryParse(Console.ReadLine(), out int limitAmount))
            {
                var report1 = stock.Where(p => p.Amount < limitAmount);

                if (report1 != null && report1.Count() > 0)
                {
                    Console.WriteLine($"Relatórios 1: Produtos com estoque abaixo de {limitAmount}: ");
                    foreach (var product in report1)
                    {
                        Console.WriteLine($"Nome do produto: {product.Name} - Quantidade em estoque: {product.Amount}");
                    }
                }
                else
                {
                    throw new ProductNotFoundException("Não existe produto para esses dados informados!");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro válido.");
            }

            Console.Write("Informe o preço minímo: ");
            if (double.TryParse(Console.ReadLine(), out double minValue))
            {
                Console.Write("Informe o preço máximo: ");
                if (double.TryParse(Console.ReadLine(), out double maxValue))
                {
                    var report2 = stock.Where(p => p.Price >= minValue && p.Price <= maxValue);

                    if (report2 != null && report2.Count() > 0)
                    {
                        Console.WriteLine($"Relatório 2: Produtos com o preço em R${minValue} e R${maxValue}");
                        foreach (var product in report2)
                        {
                            Console.WriteLine($"Nome do produto: {product.Name} - Preço unitário: {product.Price}");
                        }

                    }
                    else
                    {
                        throw new ProductNotFoundException("Não existe produto para esses dados informados!");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número decimal válido.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número decimal válido.");
            }

            var report3 = stock.Select(p => new { Name = p.Name, TotalValue = p.Amount * p.Price, Price = p.Price });

            if (report3 != null && report3.Count() > 0)
            {
                Console.WriteLine("Relatório 3: Valor total do estoque por produto");
                foreach (var product in report3)
                {
                    Console.WriteLine($"Nome do produto: {product.Name} - Valor total do Estoque: {Math.Round(product.TotalValue, 2)} - Preço unitário: {product.Price}");
                }

            }
            else
            {
                throw new ProductNotFoundException("Não existe produto para esses dados informados!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida!");
        }
        catch (ProductNotFoundException e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }
    }
}

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException(string message) : base(message)
    {
    }
}