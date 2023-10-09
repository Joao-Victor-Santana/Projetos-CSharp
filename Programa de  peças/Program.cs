using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loja();
        }

        static void Loja ()

        {
            Console.Clear();

           Console.WriteLine("Olá Seja Bem-vindo (a) a nossa loja virtual");
           Console.WriteLine("-------------------------------------------");
           Console.WriteLine("Para prosseguir pressione ENTER e aguarde 4 segundos");
           Console.ReadKey();
           Thread.Sleep(4000);
           Console.WriteLine("Olá, é um prazer receber você aqui");
           Console.WriteLine("Como posso te ajudar?");
           Console.WriteLine("----------------------------------");
           Console.WriteLine("Temos os seguintes produtos disponíveis: ");
           Console.WriteLine("");
           Console.WriteLine("1- Ferro");
           Console.WriteLine("2- Cobre");
           Console.WriteLine("3- Vidro");
           Console.WriteLine("");
           Console.WriteLine("Faça sua escolha: ");

           int esclh= Convert.ToInt32(Console.ReadLine());

           switch (esclh)
           {
            case 1:
                Ferro();
                
            break;

            case 2:
                Cobre();
            break;

            case 3:
                Vidro();
            break;
           }
           

        }

        static void Ferro()
        {
            Console.Clear();

            double ferro= 7.50;
            
            Console.WriteLine("Escolha quantas unidades de Ferro deseja adquirir: ");
            int esclh2 = Convert.ToInt32(Console.ReadLine());
            double quant2= ferro * esclh2;

            Console.WriteLine("Você escolheu: " + esclh2 + " Unidades de Ferro");
            Console.WriteLine("O valor total a ser pago é: R$" + quant2);
        }

        static void Cobre ()
        {
            Console.Clear();

            double cobre = 7.50;
            
            Console.WriteLine("Escolha quantas unidades de Cobre deseja adquirir: ");
            int esclh2 = Convert.ToInt32(Console.ReadLine());
            double quant2= cobre * esclh2;

            Console.WriteLine("Você escolheu: " + esclh2 + " Unidades de Cobre");
            Console.WriteLine("O valor total a ser pago é: R$" + quant2);
        }
        
        static void Vidro ()
        {
            Console.Clear();

            double vidro= 5.50;
            
            
            Console.WriteLine("Escolha quantas unidades de Vidro deseja adquirir: ");
            int esclh2 = Convert.ToInt32(Console.ReadLine());
            double quant2= vidro * esclh2;

            Console.WriteLine("Você escolheu: " + esclh2 + " Unidades de Ferro");
            Console.WriteLine("O valor total a ser pago é: R$" + quant2);
        }
    }

}