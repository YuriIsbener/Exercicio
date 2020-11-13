using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int idadeMes;
            int idadeDias;
            int idadeMinutos;

            Console.WriteLine("Qual sua idade?");
            idade = int.Parse(Console.ReadLine());
            
            idadeMes = idade*12;
            Console.WriteLine("Sua idade em meses é: "+idadeMes);

            idadeDias = idade*365;
            Console.WriteLine("Sua idade em dias é: "+idadeDias);

            idadeMinutos = (idadeDias*24)*60;
            Console.WriteLine("Sua idade em minutos é: "+idadeMinutos);



        }
    }
}
