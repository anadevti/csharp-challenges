namespace csharp_challenges.Lambda_Function;

// ✅ Nível Fácil (Fundamentos de Lambda + LINQ Básico)

public class EasyLevelChallengeLambdas
{
    // Desafio 1
    // Dada uma lista de inteiros, retornar apenas os números pares usando Where com lambda.
    public void LambdaChallengeNumbers()
    {
        List<int> numbers = [1,2,3,4,5,6,7,8,9,10];
        
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
                                        //    ↑    ↑
                                        //    |    └─ CORPO da lambda (a expressão/lógica)
                                        //    └────── PARÂMETRO da lambda
        Console.WriteLine($"Os Numeros Pares são:"+string.Join(",",evenNumbers));
    }

    // Desafio 2
    //Usar Select com uma expressão lambda para transformar ["ana", "mario", "julia"] em ["ANA", "MARIO", "JULIA"].
    public void LambdaChallengeNamesList()
    {
        List<String> names = ["ana", "mario", "julia"];
        var namesUpper = names.Select(n => n.ToUpper()).ToList();
        
        Console.WriteLine($"Names utilizando o ToUpper:"+string.Join(",",namesUpper));
    }
    
    // Desafio 3
    // Usar Count + lambda para identificar quantas palavras têm tamanho > 5.
    public void LambdaChallengeWordsList()
    {
        List<String> phrases = ["Bank Account", "Tesouraria", "Time de Caixa & Liquidez", "Teste", "testee"];
        var phrasesCount = phrases.Count(p => p.Length > 5);
        
        Console.WriteLine($"Palavras com tamanho maior que cinco :"+string.Join(",",phrasesCount));
    }
    // Desafio 4
    // Usar OrderBy para ordenar uma lista de idades em ordem crescente.

    public void LambdaChallengeAgeList()
    {
        List<int> ages = [10, 9, 55, 80];
        var agesOrdered = ages.OrderBy(a => a).ToList();
        
        Console.WriteLine($"Lista de idades ordenada em ordem Crescente: "+string.Join(",",agesOrdered));
    }
}