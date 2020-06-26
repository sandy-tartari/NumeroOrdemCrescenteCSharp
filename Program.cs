using System;

namespace NumeroOrdemCrescente
{
    class Program

    {
        static void Main(string[] args)
        { 
            int [] listanumeros = new int  [5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um número:");
                listanumeros[i] = int.Parse(Console.ReadLine());
               
            }
            Array.Sort(listanumeros);
            foreach (int i in listanumeros)
            {
                Console.WriteLine("" + i);
            }
        }
        
    }
} 