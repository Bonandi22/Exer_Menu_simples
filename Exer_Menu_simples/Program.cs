using System;

namespace Exer_Menu_simples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int option;

            do
            {

                Console.WriteLine(" Escolha um dos seguintes pratos");
                Console.WriteLine(" 1 - Bitoque");
                Console.WriteLine(" 2 - Picanha");
                Console.WriteLine(" 3 - Dourada");
                Console.WriteLine(" 4 - Açorda");

                option = Convert.ToInt32(Console.ReadLine());

                if (option < 1 || option > 4)
                {
                    Console.Clear();
                    Console.WriteLine(" Opção inválida");
                }


            } while (option < 1 || option > 4);                                   

            switch (option)
            {
                case 1:
                    Console.WriteLine(" Escolheste o Bitoque");
                    break;
                case 2:
                    Console.WriteLine(" Escolheste a Picanha");
                    break;
                case 3:
                    Console.WriteLine(" Escolheste a Dourada");
                    break;
                default:
                    Console.WriteLine(" Escolheste a Açorda");
                    break;
            }


        }
    }
}
