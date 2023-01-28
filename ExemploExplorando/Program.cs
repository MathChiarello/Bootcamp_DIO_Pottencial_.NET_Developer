using ExemploExplorando.Models;
using System.Globalization;

// UTILIZANDO DICTIONARY NO C#

// Instânciando um dicionário

Dictionary<string, string> estados = new Dictionary<string, string>();

// incluindo dados

estados.Add("SP" , "São Paulo");
estados.Add("BA" , "Bahia");
estados.Add("MG" , "Minas Gerais");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} , Valor: {item.Value}");
}


estados.Remove("BA");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} , Valor: {item.Value}");
}

// Verificando se uma chave existe no dicionário

string chave = "BA";

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"A chave {chave} já existe no dicionário");
} 
else
{
    Console.WriteLine($"A chave {chave} não existe no dicionário. Pode seguir com a inclusão");
}




/*

// UTILIZANDO PILHAS
// Segue a regra LIFO (Last In , First Out)

Stack<int> pilha = new Stack<int>();

// Inserindo itens na pilha

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

// Removendo um item da pilha
Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

*/








/*

// UTILIZANDO FILAS (QUEUE) NO C#
// Segue a regra FIFO (First In , First Out)

// Instanciando uma fila
Queue<int> fila = new Queue<int>();

// Inputando dados na fila
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);


foreach (int item in fila)
{
    Console.WriteLine(item);
}

// Removendo item da Fila - O primeiro que entrou, nesse caso o número 2

fila.Dequeue();

foreach (int item in fila)
{
    Console.WriteLine(item);
}


*/









// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não encontrado! >> {ex.Message}");
// }

// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Diretórionão encontrado! >> {ex.Message}");
// }

// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}");
// }




















// DateTime data = DateTime.Now;

// Console.WriteLine(data);
// // Formatando minha data informando o que quero que mostre
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// // Mostra só a data
// Console.WriteLine(data.ToShortDateString());
// // Mostra só a hora
// Console.WriteLine(data.ToShortTimeString());


















/*

// TROCA A CULTURA DE TODO O SCRIPT DE ACORDO COM O INFORMADO
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;
// Formata tirando  indicador de moeda
Console.WriteLine(valorMonetario.ToString("N2"));
// Formata com 2 casas decimais
Console.WriteLine(valorMonetario.ToString("C2"));
// Formata com 4 casas decimais
Console.WriteLine(valorMonetario.ToString("C4"));


double porcentagem = .3421;
// Formata em porcentagem
Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
// Formata na forma como desejar
Console.WriteLine(numero.ToString("##-##-##"));


// UTILIZANDO O CONSTRUTOR PARA INFORMAR NOME E SOBRENOME LOGO NA INSTANCIAÇÃO
Pessoa p1 = new Pessoa(nome: "Matheus" ,sobrenome: "Chiarello");

// UTILIZANDO O CONSTRUTOR PADRÃO E PASSANDO OS VALORES APENAS DEPOIS...
Pessoa p2 = new Pessoa();
p2.Nome = "leonardo";
p2.Sobrenome = "ramos";

Curso CursoDeIngles = new Curso();
CursoDeIngles.NomeCurso = "Inglês Básico";
CursoDeIngles.Alunos = new List<Pessoa>();

CursoDeIngles.AdicionarAluno(p1);
CursoDeIngles.AdicionarAluno(p2);
CursoDeIngles.ListarAlunos();

*/