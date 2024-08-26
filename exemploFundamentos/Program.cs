using exemploFundamentos.Models;

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":

        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal.");
        break;

}


// if(letra == "a" || 
// letra == "e" ||
// letra == "i" ||
// letra == "o" ||
// letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }

// if(letra == "a"){
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e"){
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i"){
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o"){
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u"){
//     Console.WriteLine("Vogal");
// }
// else{
//     Console.WriteLine("Não é uma vogal.");
// }



// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;

// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade em estoque: {quantidadeCompra}"); 
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");


// if(quantidadeCompra == 0){
//     Console.WriteLine("Venda Inválida");
// }
// else if(possivelVenda){
//     Console.WriteLine("Venda realizada");
// }
// else{
//     Console.WriteLine("Desculpa. Não temos a quantidade desejada em estoque.");
// }

// string a = "15-";
// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");


// ordem de operadores 
// double a = 4 / (2 + 2);
// Console.WriteLine(a);





// Cast implicito
// int a = 5;
// double b = a;


// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);

// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);


// Cast - Casting
//int a = Convert.ToInt32("5");

// int a = int.Parse("5");
// Console.WriteLine(a);

// int a = 10;
// int b = 10;
// int c = a + b;

// c = c + 5;

// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);




// string apresentacao = "Olá, seja bem vindo!!!";

// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);



// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preço: " + preco);
// Console.WriteLine("Valor da variável condição: " + condicao);



//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Eduardo";
//pessoa1.Idade = 30;
//pessoa1.Apresentar();