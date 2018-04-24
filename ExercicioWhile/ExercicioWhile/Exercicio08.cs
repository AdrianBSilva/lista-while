using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioWhile
{
    class Exercicio08
    {
        public Exercicio08()
        {
            Console.Write("Quantos caracteres deseja digitar: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            string palavra = "";
            int i = 0;

            while (i < quantidade)
            {

                char caracter = Console.ReadLine()[0];

                palavra = palavra + caracter;
                
                i = i + 1;
            }
            Console.WriteLine(palavra);
            

        }
    }
}
