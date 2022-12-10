using System;
using ExemploFundamentos.Common.Models;


// ESSA PARTE RECEBE CADA FRASE COM DOIS NÚMEROS E INSERE EM UMA LISTA PARA VERIFICAÇÃO NA PARTE 2
// MEU ERRO É QUE EU TINHA ENTENDIDO QUE EU DEVERIA RECEBER TODAS AS ENTRADAS PRIMEIRAMENTE E DEPOIS TESTÁ-LAS,
// QUANDO NA REALIDADE, RECEBE UMA SENTENÃ (OU SEJA, DOIS NÚMEROS) POR VEZ.
// ----------------------------------------------------------------
int qt = Convert.ToInt32(Console.ReadLine());
List<string> entrada_lista = new List<string>();

for (int entrada_numero = 0;entrada_numero < (qt) ;entrada_numero++)
{
    string dois_numeros = Console.ReadLine();
    string[] numero_separado = dois_numeros.Split(' ');

    foreach (var numero in numero_separado)
    {
        entrada_lista.Add(numero);
    }

// ----------------------------------------------------------------

}

    for (int num = 0; num < (qt * 2); num += 2)
    {
        string n1 = entrada_lista[num];
        string n2 = entrada_lista[num + 1];
        string n1Tratado = n1;
        string n2Tratado = n2;

        if (n1.Length == 1)
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

        if (n2.Length == 1)
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
        }
        else
        {
            Console.WriteLine("nao encaixa");
        }
}