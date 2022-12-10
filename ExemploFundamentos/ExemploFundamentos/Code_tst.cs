
using System;
using ExemploFundamentos.Common.Models;


/*

// ================= USANDO LISTAS ====================== //

List<string> ListaString = new List<string>() {"MG" , "SP" , "RO" , "CE"};


foreach(string item in ListaString) {Console.WriteLine(item);} 

ListaString.Add("RR");

foreach(string item in ListaString) {Console.WriteLine(item);} 

ListaString.Remove("SP");

foreach(string item in ListaString) {Console.WriteLine(item);} 


// ================= USANDO ARRAY ====================== //


int[] arrayInteiros = new int[3] {64,50,39};

for(int contador = 0; contador < arrayInteiros.Length;contador++) 
{
    Console.WriteLine($"Posicao Nº {contador} = {arrayInteiros[contador]}");
}



// ================= USANDO A CLASSE PESSOA ====================== //



Pessoa pessoa1 = new Pessoa();

pessoa1.Idade = 25;
pessoa1.Nome = "Matheus Chiarello";

pessoa1.Apresentar();



// ================= MENU INTERATIVO ====================== //

string? opcao = "0";

while(opcao != "4")
{
    Console.WriteLine(

    "Escolha uma Opção Abaixo:\n\n" + 

    "1 - Cadastrar Cliente\n" + 
    "2 - Buscar Cliente\n" + 
    "3 - Apagar Cliente\n" + 
    "4 - Encerrar\n\n"
    );


    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastrando cliente...");
            break;
        case "2":
            Console.WriteLine("Buscando cliente...");
            break;
        case "3":
            Console.WriteLine("Apagando cliente...");
            break;
        case "4":
            Console.WriteLine("Encerrando...");
            //Environment.Exit(0);
            break;
        
        default:
            Console.WriteLine("Opção Invalida");
            break;
    }
}

Console.WriteLine("Operação Encerrada!");



// ================= DO-WHILE ====================== //

int soma = 0 , numero = 0;

do
{
    Console.Write("Digite um número: [Zero para parar]: ");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while(numero != 0);

Console.WriteLine($"A soma dos números é {soma}");


// ================= TABUADA ====================== //

// for(declaração da variável;condição;incremento)

Console.Write("Digite um número para visualização da tabuada: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{num} x {contador} = {num * contador}");
}


// ================= SWITCH - VALIDAÇÃO VOGAL ====================== //

Console.WriteLine("Digite uma letra:");
string? letra = Console.ReadLine();

switch(letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}



*/