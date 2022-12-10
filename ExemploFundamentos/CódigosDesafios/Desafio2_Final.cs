
/*

A GRANDE DIFERENÇA ESTÁ NO MÉTODO ENDSWITH QUE JÁ FAZ TODA A VALIDAÇÃO QUE TEM EXECUTAR MENUALMENTE NA VERSÃO 2,
COM ISSO O CÓDIGO FICA MUITO MAIS SIMPLES

TRÊS LIÇÕES:
1. ENTENDER QUAL JÁ É O CÓDIGO DE ÍNICIO QUE ESTÁ NO DESAFIO POIS ELE PODE TE AJUDAR
2. SEMPRE PENSAR QUE JÁ PODE TER ALGUM MÉTODO OU ALGO CRIADO QUE VAI FAZER AQUILO QUE VOCÊ DESEJA
3. FATORAR O CÓDIGO SEMPRE, PARA FICAR MAIS SIMPLES E OBJETIVO

*/

int qt = Convert.ToInt32(Console.ReadLine());

for (int x = 0; x < qt; x++)
    {
        string[] numeros = Console.ReadLine().Split(' ');

        string primeiro_numero = numeros[0];
        string segundo_numero = numeros[1];

        if (primeiro_numero.EndsWith(segundo_numero))
            Console.WriteLine("encaixa");
        else
            Console.WriteLine("nao encaixa");
    }