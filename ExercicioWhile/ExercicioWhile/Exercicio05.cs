using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioWhile
{
    class Exercicio05
    {
        public Exercicio05()
        {
            Console.Write("Imforme Um Número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Imforme Um Número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("           MENU          ");
            Console.WriteLine(" ________________________");
            Console.WriteLine("| 1         | SOMAR      |");
            Console.WriteLine("| 2         | SUBTRAIR   |");
            Console.WriteLine("| 3         | MULTIPLICAR|");
            Console.WriteLine("| 4         | DIVIDIR    |");
            Console.WriteLine("| 5         | SAIR       |");
            Console.WriteLine("|___________|____________|");

            Console.Write("Sua Opção: ");
            double escolha = Convert.ToDouble(Console.ReadLine());

            while (escolha != 5)
            {

                if (escolha == 1)
                {
                    Console.WriteLine("Resposta: " + (numero1 + numero2));

                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Resposta: " + (numero1 - numero2));
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("Resposta: " + numero1 * numero2);
                }
                else if (escolha == 4)
                {
                    Console.WriteLine("Resposta: " + numero1 / numero2);

                }
                
                else if ((escolha < 1) || (escolha > 5))
                {
                    Console.WriteLine("Engraçadinho hehe");
                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("           MENU          ");
                Console.WriteLine(" ________________________");
                Console.WriteLine("| 1         | SOMAR      |");
                Console.WriteLine("| 2         | SUBTRAIR   |");
                Console.WriteLine("| 3         | MULTIPLICAR|");
                Console.WriteLine("| 4         | DIVIDIR    |");
                Console.WriteLine("| 5         | SAIR       |");
                Console.WriteLine("|___________|____________|");

                Console.Write("Sua Opção: ");
                escolha = Convert.ToDouble(Console.ReadLine());
                
            }

               
                
          
         
        }
    }
}
