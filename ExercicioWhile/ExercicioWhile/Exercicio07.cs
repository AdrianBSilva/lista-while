using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioWhile
{
    class Exercicio07
    {
        public Exercicio07()
        {
            int i = 0;
            double menorPeso = int.MaxValue, maiorPeso = int.MinValue,
                maiorAltura = int.MinValue, menorAltura = int.MaxValue,
                goleador = int.MaxValue, maiorAmarelo = int.MinValue,
                maiorVermelho = int.MinValue, menorAmarelo = int.MaxValue,
                menorVermelho = int.MaxValue, quantidadeDeAmarelos = 0,
                quantidadeDeVermelhos = 0;
            string nomeMenorPeso = "", nomeMaiorPeso = "", nomeMenorAltura = "",
                nomeMaiorAltura = "", nomeMaiorAmarelo = "", nomeMaiorVermelho = "",
                nomeMenorAmarelo = "", nomeMenorVermelho = "", maiorNome = "", menorNome = maiorNome, feminino = "", masculino = "";

                while (i < 2)
                {
                    Console.WriteLine("Nome do jogador: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Idade Do jogador: ");
                    double idade = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Peso do jogador: ");
                    double peso = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Sexo do jogador, F ou M: ");
                    string sexo = Console.ReadLine().ToLower();


                    Console.WriteLine("Altura do jogador: ");
                    double altura = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Quantidade de Gols marcados: ");
                    double gols = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Quantidade de cartões amarelos recebidos: ");
                    double amarelo = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Quantidade de cartões vermelhos recebidos: ");
                    double vermelho = Convert.ToDouble(Console.ReadLine());

                   
                   
                    Console.Clear();

                    if (peso < menorPeso)
                    {
                        menorPeso = peso;
                        nomeMenorPeso = nome;
                    }
                    if (peso > maiorPeso)
                    {
                        maiorPeso = peso;
                        nomeMaiorPeso = nome;
                    }
                    if (altura < menorAltura)
                    {
                        menorAltura = altura;
                        nomeMenorAltura = nome;
                    }
                    if (altura > maiorAltura)
                    {
                        maiorAltura = altura;
                        nomeMaiorAltura = nome;
                    }
                    if (sexo == "f")
                    {
                        feminino = feminino + 1;
                    }
                    if (sexo == "m")
                    {
                        masculino = masculino + 1;
                    }
                    if (amarelo < menorAmarelo)
                    {
                        menorAmarelo = amarelo;
                        nomeMenorAmarelo = nome;
                    }
                    if (amarelo > maiorAmarelo)
                    {
                        maiorAmarelo = amarelo;
                        nomeMaiorAmarelo = nome;
                    }
                    if (vermelho < menorVermelho)
                    {
                        menorVermelho = vermelho;
                        nomeMenorVermelho = nome;
                    }
                    if (vermelho > maiorVermelho)
                    {
                        maiorVermelho = vermelho;
                        nomeMaiorVermelho = nome;
                    }
                    if (nome.Length > maiorNome.Length)
                    {
                        maiorNome = nome;
                    }
                    if (nome.Length < maiorNome.Length)
                    {
                        menorNome = nome;
                    }





                    i = i + 1;
                }

            Console.WriteLine("O jogador com menor peso é o(a): " + nomeMenorPeso + " Com " + menorPeso + " kg \n");
            Console.WriteLine("O jogador com maior peso é o(a): " + nomeMaiorPeso + " Com " + maiorPeso + " kg \n");
            Console.WriteLine("O jogador com a menor altura é o(a): " + nomeMenorAltura + " Com " + menorAltura + "\n");
            Console.WriteLine("O jogador com a maior altura é o(a): " + nomeMaiorAltura + " Com " + maiorAltura + "\n");
            Console.WriteLine("Quantidade de jogadoras: " + feminino + "\n");
            Console.WriteLine("Quantidade de jogadores: " + masculino + "\n");
            Console.WriteLine("Jogador com menos cartões amarelos foi o(a): " + nomeMenorAmarelo + " Com " + menorAmarelo + " Amarelos \n" );
            Console.WriteLine("Jogador com mais cartões amarelos foi o(a): " + nomeMaiorAmarelo + " Com " + maiorAmarelo + " Amarelos \n");
            Console.WriteLine("Jogador com menos cartões vermelhos foi o(a): " + nomeMenorVermelho + " Com " + menorVermelho + " Vermelhos \n");
            Console.WriteLine("Jogador com mais cartões vermelhos foi o(a): " + nomeMaiorVermelho + " Com " + maiorVermelho + " Vermelhos \n");
            Console.WriteLine("O jogador com maior nome é o(a): " + maiorNome);
            Console.WriteLine("O jogador com menor nome é o(a): " + menorNome);
        }
    }
}
