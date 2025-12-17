namespace csharp_challenges.Lambda_Function;

// Desafio 1
// Filtrando e transformando uma lista de objetos
// Crie uma classe Produto com as propriedades Id, Nome, Preco e Categoria.
// Monte uma List<Produto> com pelo menos 10 itens, de categorias diferentes.
// Usando lambda expressions e métodos de extensão LINQ (Where, Select, OrderBy etc.), crie uma nova lista contendo apenas:
// Produtos da categoria "Eletronico"
// Com preço maior que 100
// Ordenados por preço decrescente
// A nova lista deve conter apenas objetos anônimos com Nome e Preco (sem Id e Categoria).

// resolução desafio 1
public class IntermediateLevelChallenge
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }

    public List <Product> products = new List<Product>()
        {
            new Product { Id = "1", Name = "Monitor", Price = 150m, Category = "Electronics" },
            new Product { Id = "2", Name = "Smartphone", Price = 800m, Category = "Electronics" },
            new Product { Id = "3", Name = "Refrigerator", Price = 1200m, Category = "Appliances" },
            new Product { Id = "4", Name = "Sofa", Price = 500m, Category = "Furniture" },
            new Product { Id = "5", Name = "Headphones", Price = 200m, Category = "Electronics" },
            new Product { Id = "6", Name = "Blender", Price = 80m, Category = "Appliances" },
            new Product { Id = "7", Name = "Desk", Price = 300m, Category = "Furniture" },
            new Product { Id = "8", Name = "Laptop", Price = 1000m, Category = "Electronics" },
            new Product { Id = "9", Name = "Microwave", Price = 250m, Category = "Appliances" },
            new Product { Id = "10", Name = "Chair", Price = 100m, Category = "Furniture" },
        };

    public IEnumerable<object> GetProductsElectronics()
    {
        var result = products
            .Where(p => p.Category == "Electronics" && p.Price > 100m)
            .OrderByDescending(p => p.Price)
            .Select(p => new { p.Name, p.Price })
            .ToList();

        Console.WriteLine($"Deve conter apenas objetos anônimos com Nome e Preco: "+string.Join(",",result));
        return result;
    }
}

// Desafio 2
// Agrupamento e agregação com listas e lambdas 
//     Crie uma classe Venda com as propriedades Vendedor, Valor (decimal) e Data (DateTime).
//     Monte uma List<Venda> com vendas de pelo menos 3 vendedores diferentes, em meses diferentes.
//     Usando GroupBy, lambdas e outras funções (Select, Sum, OrderByDescending):
//     Agrupe as vendas por Vendedor e calcule o total vendido por cada um.
//     Encontre o vendedor com maior valor total vendido.
//     Agrupe as vendas por mês/ano (por exemplo, 2025-01, 2025-02) e calcule o total vendido em cada mês.
// TODO: resolver desafio 02