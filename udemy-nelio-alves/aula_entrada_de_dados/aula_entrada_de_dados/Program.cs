
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com seu nome completo:");
            string frase = Console.ReadLine();

            Console.WriteLine("Nome: " + frase);

            //Dividindo a string em partes.

            Console.Write("Digite 3 palavras: ");
            String p = Console.ReadLine();

            string[] array = p.Split(' '); 

            
            String p1 = array[0];
            String p2 = array[1];
            String p3 = array[2];

            Console.Write(p1 + "-" + p2 + "-" + p3);


        }
    }
}