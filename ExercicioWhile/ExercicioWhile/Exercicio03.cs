using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioWhile
{
    class Exercicio03
    {
        public Exercicio03()
        {
            Console.WriteLine("Digite seu peso: ");
            double peso = Convert.ToInt32(Console.ReadLine());
            int quantidade = 0;
            while ((peso > 0) && (peso < 300))
            {
                Console.WriteLine("Digite seu peso: ");
                 peso = Convert.ToDouble(Console.ReadLine());
                quantidade = quantidade + 1; 
            }
            Console.WriteLine("Número de cadastros: " + quantidade);
        }
    }
}
