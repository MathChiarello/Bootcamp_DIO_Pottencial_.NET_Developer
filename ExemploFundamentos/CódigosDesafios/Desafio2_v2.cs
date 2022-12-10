
int qt = Convert.ToInt32(Console.ReadLine());

for (int num = 0; num < qt; num++)
    {
        string dois_numeros = Console.ReadLine();
        string[] numero_separado = dois_numeros.Split(' ');

        string n1 = numero_separado[0];
        string n2 = numero_separado[1];
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