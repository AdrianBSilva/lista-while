using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioWhile
{
    class Exercicio02
    {
        public Exercicio02()
        {
            Console.WriteLine("Digite uma idade para sair digitar qualquer número maior que 128: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            while(idade < 129)
            {
                Console.WriteLine("Digite uma idade para sair digitar qualquer número maior que 128");
                idade = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
