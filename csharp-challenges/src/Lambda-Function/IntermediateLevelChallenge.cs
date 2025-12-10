namespace csharp_challenges.Lambda_Function;


// TODO:
// Desafio 1
// Filtrando e transformando uma lista de objetos
// Crie uma classe Produto com as propriedades Id, Nome, Preco e Categoria.
// Monte uma List<Produto> com pelo menos 10 itens, de categorias diferentes.
// Usando lambda expressions e métodos de extensão LINQ (Where, Select, OrderBy etc.), crie uma nova lista contendo apenas:
// Produtos da categoria "Eletronico"
// Com preço maior que 100
// Ordenados por preço decrescente
// A nova lista deve conter apenas objetos anônimos com Nome e Preco (sem Id e Categoria).

// Desafio 2
// Agrupamento e agregação com listas e lambdas 
//     Crie uma classe Venda com as propriedades Vendedor, Valor (decimal) e Data (DateTime).
//     Monte uma List<Venda> com vendas de pelo menos 3 vendedores diferentes, em meses diferentes.
//     Usando GroupBy, lambdas e outras funções (Select, Sum, OrderByDescending):
//     Agrupe as vendas por Vendedor e calcule o total vendido por cada um.
//     Encontre o vendedor com maior valor total vendido.
//     Agrupe as vendas por mês/ano (por exemplo, 2025-01, 2025-02) e calcule o total vendido em cada mês.

public class IntermediateLevelChallenge
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        private List<Product> products = new List<Product>()
        {
            new Product { Id = "2837832hdaus", Name = "Monitor", Price = 10m, Category = "Electronics" },
            // TODO: seguir com o desafio
        };

    }
}