//Exercício 1 — Calculando uma compra
// Console.Write("Digite o nome do produto");

// string? Nome = Console.ReadLine();

// Console.Write("Digite a quantidade comprada");

// string? quantidadeComprada = Console.ReadLine();

// if(!int.TryParse(quantidadeComprada, out int numeroCompras))
// {
//     Console.WriteLine("Digite um número válido");
// }

// Console.Write("Digite o preço do produto");

// string? preco = Console.ReadLine();

// if(!decimal.TryParse(preco, out decimal precoUnitario))
// {
//     Console.WriteLine("Digite um número válido");
// }

// decimal totalCompra = numeroCompras * precoUnitario;

// Console.WriteLine($"O produto {Nome} foi comprado {numeroCompras} vezes. Valor total de compras é de {totalCompra:F2}");


//Exercício 2 — Classificação de notas

// Console.Write("Digite seu nome: ");
// string? Nome = Console.ReadLine();

// Console.Write("Insira sua nota: ");
// string? notaString = Console.ReadLine();

// if(!decimal.TryParse(notaString, out decimal nota))
// {
//     Console.WriteLine("Insira um número válido");
// }

// if(nota >= 0 && nota <= 10)
// {
//     if(nota >= 7)
//     {
//         Console.WriteLine($"Aluno {Nome} foi aprovado, sua nota foi {nota}");
//     }
//     else if(nota >= 5)
//     {
//         Console.WriteLine($"Aluno {Nome} está de recuperação, sua nota foi {nota}");
//     }
//     else
//     {
//         Console.WriteLine($"Aluno {Nome} está reprovado, sua nota foi {nota}");
//     }
// }
// else
// {
//     Console.WriteLine("Insira uma nota válida!");
// }

//Exercício 3 — Adivinhe o número

int numeroSecreto = 62;

bool acerto = false;

int contagem = 0;

while(!acerto)
{
    Console.Write("Advinhe o número secreto");
    string? palpite = Console.ReadLine();
    if(!int.TryParse(palpite, out int numeroTentativa)) 
        Console.WriteLine("Insira um número válido");

    contagem++;

    if(numeroTentativa > numeroSecreto)
        Console.WriteLine("Seu palpite é maior que o número secreto");
    else if(numeroTentativa < numeroSecreto)
        Console.WriteLine("Seu palpite é menor que o número secreto");
    else
    {
        Console.WriteLine($"Parabéns, você acertou, o número era {numeroSecreto}. Você teve {contagem} tentativas");
        acerto = true;
    }
}



// do
// {
//     Console.Write("Advinhe o número secreto");
//     string? palpite = Console.ReadLine();
//     if(!int.TryParse(palpite, out int numeroTentativa)) 
//         Console.WriteLine("Insira um número válido");

//     contagem++;
    
//     if(numeroTentativa > numeroSecreto)
//         Console.WriteLine("Seu palpite é maior que o número secreto");
//     else if(numeroTentativa < numeroSecreto)
//         Console.WriteLine("Seu palpite é menor que o número secreto");
//     else
//     {
//         Console.WriteLine($"Parabéns, você acertou, o número era {numeroSecreto}. Você teve {contagem} tentativas");
//         acerto = true;
//     }

// } while(!acerto);



