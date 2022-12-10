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