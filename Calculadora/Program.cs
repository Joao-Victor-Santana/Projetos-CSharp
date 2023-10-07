using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
    
        }

        static void Menu ()
        {
           //Primeira Parte do Menu

            Console.Clear();
            Console.WriteLine ("Olá, Seja muito bem-vindo (a)");
            Console.WriteLine ("-------------------------------");
            Console.WriteLine ("Para continuar pressione ENTER e aguarde 3 segundos");
            Console.ReadKey ();
            Thread.Sleep (3000);
           
           // Segunda parte do menu
            Console.Clear();
            Console.WriteLine ("Como posso te ajudar?");
            Console.WriteLine ("Confira as opções a baixo");
            Console.WriteLine ("--------------------------");
            Console.WriteLine ("1- SOMA");
            Console.WriteLine ("2- SUBTRAÇÂO");
            Console.WriteLine ("3- MULTIPLICAÇÂO");
            Console.WriteLine ("4- DIVISÂO");
            Console.WriteLine ("0- RETORNAR");

            Console.WriteLine ("Escolha um opção");

            int esc= int.Parse(Console.ReadLine());

            switch(esc)
            {
                
                case 1: SOMA();
                break;

                case 2: SUBTRACAO();
                break;

                case 3: MULTIPLICACAO();
                break;

                case 4: DIVISAO();
                break;
            }
        }
        static void SOMA ()
        {
            Console.Clear ();
            Console.WriteLine ("Digite o primeiro número: ");
            float n1= float.Parse(Console.ReadLine());
            Console.WriteLine ("Digite o segundo número: ");
            float n2= float.Parse(Console.ReadLine()); 

            float resultado= n1 + n2;
            Console.WriteLine ("O resulatdo é: " + resultado);
        }
        static void SUBTRACAO()
        {
             Console.Clear ();
            Console.WriteLine ("Digite o primeiro número: ");
            float n1= float.Parse(Console.ReadLine());
            Console.WriteLine ("Digite o segundo número: ");
            float n2= float.Parse(Console.ReadLine()); 

            float resultado= n1 - n2;
            Console.WriteLine ("O resulatdo é: " + resultado);

        }

        static void MULTIPLICACAO ()
        {
             Console.Clear ();
            Console.WriteLine ("Digite o primeiro número: ");
            float n1= float.Parse(Console.ReadLine());
            Console.WriteLine ("Digite o segundo número: ");
            float n2= float.Parse(Console.ReadLine()); 

            float resultado= n1 * n2;
            Console.WriteLine ("O resulatdo é: " + resultado);
        }

        static void DIVISAO()
        {
             Console.Clear ();
            Console.WriteLine ("Digite o primeiro número: ");
            float n1= float.Parse(Console.ReadLine());
            Console.WriteLine ("Digite o segundo número: ");
            float n2= float.Parse(Console.ReadLine()); 

            float resultado= n1 / n2;
            Console.WriteLine ("O resulatdo é: " + resultado);
        }
    }
}