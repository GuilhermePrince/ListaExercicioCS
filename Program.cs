// //Exercício 1 — Calculando uma compra
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


// //Exercício 2 — Classificação de notas

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

// //Exercício 3 — Adivinhe o número

// int numeroSecreto = 62;

// bool acerto = false;

// int contagem = 0;

// while(!acerto)
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
// }



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



// //Exercício 4 — Calculadora com métodos

// int somar(int a, int b)
// {
//     return a + b;
// }

// int multiplicar(int a, int b)
// {
//     return a * b;
// }

// Console.WriteLine("Insira dois numeros inteiros");
// string? num1 = Console.ReadLine();
// if(!int.TryParse(num1, out int Num1))
//     Console.WriteLine("Insira um número Válido");

// string? num2 = Console.ReadLine();
// if(!int.TryParse(num2, out int Num2))
//     Console.WriteLine("Insira um número Válido");

// int soma = somar(Num1, Num2);

// int produto = multiplicar(Num1, Num2);

// Console.WriteLine(soma);
// Console.WriteLine(produto);


// //Exercício 5 — Cadastro de notas em um array

// int qtdNotas = 3;

// float[] notas = new float[qtdNotas];
// float media = 0;

// Console.WriteLine("Insira suas notas: ");

// for(int i = 0; i < qtdNotas; i++)
// {
//     string? notaUser = Console.ReadLine();
//     if(!float.TryParse(notaUser, out float notaUserF))
//     {
//         Console.WriteLine("Insira um número válido");
//         break;
//     }
//     notas[i] = notaUserF;
// }

// for(int i = 0; i < qtdNotas; i++)
// {
//     Console.WriteLine($"Sua {i + 1}ª nota é: {notas[i]}");    
// }


// foreach(float nota in notas)
// {
//     media += nota / qtdNotas;
// }
// Console.WriteLine($"Sua média é {media:F2}");



// //Exercício 6 — Lista de produtos

// List<string> produtos = new List<string>();

// Console.WriteLine("Insira 3 produtos novos");

// for(int i = 0; i < 3; i++)
// {
//     string? produtoUser = Console.ReadLine();
//     produtos.Add(produtoUser);
// }

// Console.Write("Você possui os seguintes produtos cadastrados: ");
// foreach(string produto in produtos)
// {
//     Console.WriteLine(produto);
// }

// Console.Write("Verifique se há um produto na lista: ");
// string? produtoVerificado = Console.ReadLine();

// if(produtos.Contains(produtoVerificado))
// {
//     Console.WriteLine($"O produto {produtoVerificado} está na lista.");
// }
// else
// {
//     Console.WriteLine("Este produto não está na lista");
// }


// Console.Write("Insira um produto para removê-lo: ");
// string? produtoRemovido = Console.ReadLine();

// if(produtos.Contains(produtoRemovido))
// {
//     produtos.Remove(produtoRemovido);
//     Console.WriteLine($"O item {produtoRemovido} foi removido da lista.");
// }
// else
// {
//     Console.WriteLine("Este item não está na lista, não houve alterações.");
// }
// Console.Write("A lista tuual é: ");
// foreach(string produto in produtos)
// {
//     Console.WriteLine(produto);
// }