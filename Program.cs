using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;
            

            Console.WriteLine("digite sua primeira nota1: ");
           nota1 =double.Parse( Console.ReadLine());

            Console.WriteLine("digite sua segunda nota2: ");
           nota2 = double.Parse( Console.ReadLine());
           
            Console.WriteLine("digite sua terceira nota3: ");
           nota3 =double.Parse( Console.ReadLine());

            if ((nota1 > nota2) & (nota1 > nota3))
            {
                Console.WriteLine($"resultado:{nota1}");
            }
            else if ((nota2 > nota1) & (nota2 > nota3))
            {
                Console.WriteLine($"Resultado:{nota2}");
            }
            else
            {
                Console.WriteLine($"Resultaddo:{nota3}\n");
            }

            Main(null);
            Console.ReadKey();
        }
      
        void atv4()
        {   /*
            //atv4
            double nota1;
            double nota2;
            double media;

            Console.WriteLine("digite nota1: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite nota2: ");
            nota2 = double.Parse(Console.ReadLine());

            media = ((nota1 + nota2) / 2);


            if (media == 6)
            {
                Console.WriteLine("Media igual a 6.0");
            }
            else if (media > 6)
            {
                Console.WriteLine("Media superior a 6.0");
            }
            else
            {
                Console.WriteLine("Media inferior a 6.0");
            }


            Console.ReadKey();
            */
        }
        void atv3()
        {    
            //atv3
            float media;
            string nome;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite sua media final: ");
            media = float.Parse(Console.ReadLine());
            if (media >= 6.0)
            {
                Console.WriteLine("\n--APROVADO--\n");
            }
            else
            {
                Console.WriteLine("\n--REPROVADO--\n");
            }
            Main(null);
            Console.ReadKey();
        }
        void atv2() 
        {
            //atv2 
            //leia um numero que se maior que 100 sera somado 150 ao resultdo final
            int numero;
            Console.Write("Digite um numero: ");
            numero = Int32.Parse(Console.ReadLine());
            if (numero > 100)
            {
                Console.Write("Resultado: ");
                Console.WriteLine(numero + 150);

            }


            Main(null);
            Console.ReadKey();


        }

        void atv1()
        {

            /*
            //atividade1
            double numero;
            Console.Write("- Digite um numero:");
            numero =double.Parse(Console.ReadLine());
           
            if(numero > 10)
            {
                Console.Write("Resultado: ");
                Console.WriteLine( numero * 0.1);
            }
            else
            {
                Console.WriteLine("- Resultado:");
            }
            Main(null);
            Console.ReadKey();
            */
            
        }


    }
}
