using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioWhile
{
    class Exercicio01
    {
        public Exercicio01()
        {
            Console.WriteLine("Digite um nome ou digite fim para sair: ");
            string nome = Console.ReadLine();
            nome = nome.ToLower();

            while(nome != "fim")
            {
                Console.WriteLine("Digite um nome ou digite fim para sair: ");
                nome = Console.ReadLine().ToLower();
                
               
            }
        }
    }
}
