using System;

namespace ModoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("C# em Modo Console");
            Console.WriteLine("-------------------------");

            // Tipos de dados (Principais)
            /*
                int -> inteiros
                string -> caracteres
                float,double -> números com casa decimais
                boolean -> verdadeiro ou falso                
            */

            //exemplos                        
            bool menino = true;

            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            Console.WriteLine("Informe seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            string msgSexo = (menino == true) ? "Menino" : "Menina";

            string msg = "Meu nome é "+ nome +", tenho "+ idade +" anos e peso "+ peso +"kg. Sou "+ msgSexo;            

            Console.WriteLine("Apresentação: ");
            Console.WriteLine(msg);           
            Console.ReadKey();
        }
    }
}
