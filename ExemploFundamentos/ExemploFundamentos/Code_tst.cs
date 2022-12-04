using System;
using ExemploFundamentos.Common.Models;


// string numero = "54";
// string texto = numero.Substring(0, 2);

// Console.WriteLine(texto);


// 4
// 56234523485723854755454545478690 78690
// 5434554 543
// 1243 1243
// 54 64545454545454545454545454545454554

int qt = Convert.ToInt32(Console.ReadLine());
int x = 0;


while(x < qt)
{
    string n1 = Console.ReadLine();
    string n2 = Console.ReadLine();
    string n1Tratado = n1;
    string n2Tratado = n2;

    if(n1.Length == 1) 
    {
        n1Tratado = n1.Substring(0, 1);
    }     
    else if (n1.Length == 2)
    {
        n1Tratado = n1.Substring(0, 2);
    }
    else if (n1.Length >= 3)
    {
        n1Tratado = n1.Substring((n1.Length - 3), 3);
    }

    if(n2.Length == 1) 
    {
        n2Tratado = n2.Substring(0, 1);
    }     
    else if (n2.Length == 2)
    {
        n2Tratado = n2.Substring(0, 2);
    }
    else if (n2.Length >= 3)
    {
        n2Tratado = n2.Substring((n2.Length - 3), 3);
    }
    //Console.WriteLine(n1Tratado);
    //Console.WriteLine(n2Tratado);

    if (n1Tratado == n2Tratado)
    {
        Console.WriteLine("encaixa");
    } else {
        Console.WriteLine("nao encaixa");
    }

    x++;
}

/*
// ================= MEUS CÓDIGOS PARA O PROJETO 1 ====================== //

//int numero = 234;
//string numeroEmTexto = Convert.ToString(numero);
string numeroEmTexto = Console.ReadLine();
int produtoDaLista = 1;
int somaDaLista = 0;

List<int> listaNumero = new List<int>();

//Console.WriteLine(numeroEmTexto);

foreach(int i in numeroEmTexto)
{
    int s = i - 48;
    listaNumero.Add(s);
}

// foreach(int item in listaNumero)
// {
//     Console.WriteLine(item);
// }

foreach(int item in listaNumero)
{
    produtoDaLista *= item;
}

somaDaLista = listaNumero.Sum();

Console.WriteLine($"O produto no número informado é {produtoDaLista}");
Console.WriteLine($"A soma do número informado é {somaDaLista}");

Console.WriteLine($"O valor final esperado é {produtoDaLista - somaDaLista}");


// ================= EMTREGA DO PROJETO 1 ====================== //



using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.CompilerServices;

class DIO {
        
static void Main(string[] args){

        int n = int.Parse(Console.ReadLine());
        string numeroEmTexto = Convert.ToString(n);
        int p = 1, s = 0;
        List<int> listaNumero = new List<int>();
        
            foreach(int i in numeroEmTexto)
            {
                int g = i - 48;
                listaNumero.Add(g);
            }
            
            foreach(int item in listaNumero)
            {
                p *= item;
            }
            
            foreach(int item in listaNumero)
            {
                s += item;
            }

           Console.WriteLine(p-s);
        }
    }



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