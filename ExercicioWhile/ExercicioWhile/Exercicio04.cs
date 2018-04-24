using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioWhile
{
    class Exercicio04
    { 
        public Exercicio04()
        {
            Console.WriteLine("Quantos carros você deseja cadastra: ");
            int quantidadeDeCarros = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            string primeiraLetra = "";

            double somaAnos = 0, somaValor = 0;

            int numeroDeLetrasG = 0, numeroDeLetrasA = 0;

            int quantidade = 0;

            while (i < quantidadeDeCarros)
            {
                Console.WriteLine("Qual o modelo do carro: ");
                string modelo = Console.ReadLine();
                primeiraLetra = modelo.Substring(0).ToLower();

                Console.WriteLine("Valor do carro: ");
                double valor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ano do carro: ");
                int ano = Convert.ToInt32(Console.ReadLine());

                quantidade = quantidade + 1;
                somaAnos = somaAnos + ano;
                somaValor = somaValor + valor;
                if (primeiraLetra == "g")
                {
                    numeroDeLetrasG = numeroDeLetrasG + 1;
                }
                else if (primeiraLetra == "a")
                {
                    numeroDeLetrasA = numeroDeLetrasA + 1;
                }
                i = i + 1;
            }
            double mediaAnos = somaAnos / quantidade;
            double mediaValor = somaValor / quantidade;
            Console.WriteLine("Média de anos: " + mediaAnos);
            Console.WriteLine("Média de valores: " + mediaValor);
            Console.WriteLine("Quantidade de carros com a letra G: " + numeroDeLetrasG );
            Console.WriteLine("Quantidade de carros com a letra A: " + numeroDeLetrasA );

        }
    }
}
