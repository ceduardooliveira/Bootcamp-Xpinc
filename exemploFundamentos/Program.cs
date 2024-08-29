using exemploFundamentos.Common.Models;

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;


int[] arrayInteiroDobrado = new int [arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteiroDobrado, arrayInteiros.Length);

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

Console.WriteLine("Percorrendo o Array com o FOR");
for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
}












// Console.WriteLine("Percorrendo o Array com o FOREACH");

// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//     contadorForeach++;
// }








// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Buta";
// pessoa1.Idade = 20;
// pessoa1.Apresentar();






// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite uma opçao");
//     Console.WriteLine("1 - Cadastrar cliente.");
//     Console.WriteLine("2 - Buscar cliente.");
//     Console.WriteLine("3 - Apagar cliente.");
//     Console.WriteLine("4 - Encerrar.");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro do cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;   

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             //Environment.Exit(0);
//             break;  

//         default:
//             Console.WriteLine("Opção Inválida");   
//             break;   
//     }
// }





// int soma = 0, numero = 0;


// do
// {
//     Console.WriteLine("Digite um número (0 para parar.) ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// }while(numero != 0 );
// Console.WriteLine($"total da soma dos numeros digitados é: {soma}");



// int numero = 5;
// int contador = 0;


// while(contador <= 10)
// {
//     Console.WriteLine($"{contador}º Execução: {numero} x {contador} = {numero * contador}");
//     contador ++;

//     if(contador == 6){
//         break;
//     }
   
// }


// for(int contador = 0; contador <= 10; contador++){
//      Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Incrementando o 10");
// //numero = numero + 1;
// numeroIncremento ++;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("====================================");

// int numeroDecremento = 10;
// Console.WriteLine(numeroDecremento);

// Console.WriteLine("Decrementando o 10");
// numeroDecremento --;

// Console.WriteLine(numeroDecremento);

// Calculadora calc = new Calculadora();


// calc.RaizQuadrada(25);

// calc.Somar(10,30);
// calc.Subtrair(50,10);
// calc.Multiplicar(15,45);
// calc.Dividir(2,2);

//calc.Potencia(3,3);


// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);





// bool choveu = false;
// bool estaTarde = false;

// if(!choveu && !estaTarde){
//     Console.WriteLine("vou pedalar.");
// }
// else{
//     Console.WriteLine("vou pedalar um outro dia.");  
// }






// bool possuiPresencaMinima = true;
// double media = 8.5;

// if(possuiPresencaMinima && media >= 7){
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }






// bool ehMaiorIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if(ehMaiorIdade || possuiAutorizacaoDoResponsavel){
//     Console.WriteLine("Entrada liberada");

// }
// else{
//     Console.WriteLine("Entrada nao liberada");
// }










// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":

//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal.");
//         break;

// }


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