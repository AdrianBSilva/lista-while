using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioWhile
{
    class Exercicio06
    {
        public Exercicio06()
        {
            Console.WriteLine("                        MENU                          ");
            Console.WriteLine(" ______________________________________________________");
            Console.WriteLine("|1     |Bolos        |Bolo Brigadeiro           |29,50|");
            Console.WriteLine("|2     |Bolos        |Bolo Floresta Negra       | 2,00|");
            Console.WriteLine("|3     |Bolos        |Bolo Leite com Nuttela    |29,23|");
            Console.WriteLine("|4     |Bolos        |Bolo Mousse de Chocolate  | 7,10|");
            Console.WriteLine("|5     |Bolos        |Bolo Nega Maluca          |17,33|");
            Console.WriteLine("|6     |Doces        |Bomba de Creme            |17,71|");
            Console.WriteLine("|7     |Doces        |Bomba de Morango          | 4,82|");
            Console.WriteLine("|8     |Sanduíches   |Filé-Mignon com fritas e  |21,16|");
            Console.WriteLine("|      |             |cheddar                   |     |");
            Console.WriteLine("|9     |Sanduíche    |Hambúrguer com quijos,    |12,70|");
            Console.WriteLine("|      |             |champignon e rúcula       |     |");
            Console.WriteLine("|10    |Sanduíches   |Provolone                 |19,70|");
            Console.WriteLine("|11    |Sanduíche    |Vegetariano de berinjela  |28,22|");
            Console.WriteLine("|12    |Pizzas       |Calabresa                 | 8,98|");
            Console.WriteLine("|13    |Pizzas       |Napolitana                | 0,42|");
            Console.WriteLine("|14    |Pizzas       |Peruana                   |18,36|");
            Console.WriteLine("|15    |Pizzas       |Portuguesa                |27,50|");
            Console.WriteLine("|16    |             |SAIR                      |     |");
            Console.WriteLine("|_____________________________________________________|");

            Console.Write("Faça seu pedido: ");
            double pedido = Convert.ToInt32(Console.ReadLine());
            int bolos = 0, doces = 0, sanduiche = 0, pizzas = 0, quantidade = 0;
            double valorTotal = 0;

            while (pedido != 16)
            {
                Console.Clear();

                Console.WriteLine("                        MENU                          ");
                Console.WriteLine(" ______________________________________________________");
                Console.WriteLine("|1     |Bolos        |Bolo Brigadeiro           |29,50|");
                Console.WriteLine("|2     |Bolos        |Bolo Floresta Negra       | 2,00|");
                Console.WriteLine("|3     |Bolos        |Bolo Leite com Nuttela    |29,23|");
                Console.WriteLine("|4     |Bolos        |Bolo Mousse de Chocolate  | 7,10|");
                Console.WriteLine("|5     |Bolos        |Bolo Nega Maluca          |17,33|");
                Console.WriteLine("|6     |Doces        |Bomba de Creme            |17,71|");
                Console.WriteLine("|7     |Doces        |Bomba de Morango          | 4,82|");
                Console.WriteLine("|8     |Sanduíches   |Filé-Mignon com fritas e  |21,16|");
                Console.WriteLine("|      |             |cheddar                   |     |");
                Console.WriteLine("|9     |Sanduíche    |Hambúrguer com quijos,    |12,70|");
                Console.WriteLine("|      |             |champignon e rúcula       |     |");
                Console.WriteLine("|10    |Sanduíches   |Provolone                 |19,70|");
                Console.WriteLine("|11    |Sanduíche    |Vegetariano de berinjela  |28,22|");
                Console.WriteLine("|12    |Pizzas       |Calabresa                 | 8,98|");
                Console.WriteLine("|13    |Pizzas       |Napolitana                | 0,42|");
                Console.WriteLine("|14    |Pizzas       |Peruana                   |18,36|");
                Console.WriteLine("|15    |Pizzas       |Portuguesa                |27,50|");
                Console.WriteLine("|16    |             |SAIR                      |     |");
                Console.WriteLine("|_____________________________________________________|");

                Console.Write("Faça seu pedido: ");
                pedido = Convert.ToInt32(Console.ReadLine());

                if (pedido == 1)
                {
                    valorTotal = valorTotal + 29.50;
                    quantidade = quantidade + 1;
                    bolos = bolos + 1;
                }
                else if (pedido == 2)
                {
                    valorTotal = valorTotal + 2.00;
                    quantidade = quantidade + 1;
                    bolos = bolos + 1;
                }
                else if (pedido == 3)
                {
                    valorTotal = valorTotal + 29.53;
                    quantidade = quantidade + 1;
                    bolos = bolos + 1;
                }
                else if (pedido == 4)
                {
                    valorTotal = valorTotal + 7.10;
                    quantidade = quantidade + 1;
                    bolos = bolos + 1;
                }
                else if (pedido == 5)
                {
                    valorTotal = valorTotal + 19.33;
                    quantidade = quantidade + 1;
                    bolos = bolos + 1;
                }
                else if (pedido == 6)
                {
                    valorTotal = valorTotal + 17.71;
                    quantidade = quantidade + 1;
                    doces = doces + 1;
                }
                else if (pedido == 7)
                {
                    valorTotal = valorTotal + 4.82;
                    quantidade = quantidade + 1;
                    doces = doces + 1;
                }
                else if (pedido == 8)
                {
                    valorTotal = valorTotal + 21.16;
                    quantidade = quantidade + 1;
                    sanduiche = sanduiche + 1;
                }
                else if (pedido == 9)
                {
                    valorTotal = valorTotal + 12.70;
                    quantidade = quantidade + 1;
                    sanduiche = sanduiche + 1;
                }
                else if (pedido == 10)
                {
                    valorTotal = valorTotal + 19.70;
                    quantidade = quantidade + 1;
                    sanduiche = sanduiche + 1;
                }
                else if (pedido == 11)
                {
                    valorTotal = valorTotal + 28.22;
                    quantidade = quantidade + 1;
                    sanduiche = sanduiche + 1;
                }
                else if (pedido == 12)
                {
                    valorTotal = valorTotal + 8.98;
                    quantidade = quantidade + 1;
                    pizzas = pizzas + 1;
                }
                else if (pedido == 13)
                {
                    valorTotal = valorTotal + 0.42;
                    quantidade = quantidade + 1;
                    pizzas = pizzas + 1;
                }
                else if (pedido == 14)
                {
                    valorTotal = valorTotal + 18.36;
                    quantidade = quantidade + 1;
                    pizzas = pizzas + 1;
                }
                else if (pedido == 15)
                {
                    valorTotal = valorTotal + 27.50;
                    quantidade = quantidade + 1;
                    pizzas = pizzas + 1;
                }
            }

            double media = valorTotal / quantidade;

            Console.WriteLine("Total dos pedido: " + valorTotal);
            Console.WriteLine("Quantidade de produtos peditos: " + quantidade);
            Console.WriteLine("Quantidade de bolos pedidos: " + bolos);
            Console.WriteLine("Quantidade de doçes pedidos: " + doces);
            Console.WriteLine("Quantidade de pizzas pedidas: " + pizzas);
            Console.WriteLine("Média dos produtos: " + media);

                                     
        }
    }
}
