/* While - Executa repetidamente um trecho de código enquanto uma condição
 * for satisfeita.
 */
using System;
using System.Globalization;

class Program
{
    
    static void Main(string[] args)
    {

        /*int[] vetor = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int cont = 0;

        while (cont < vetor.Length) //só vai rodar enquanto minha condição for True.
        {
            Console.WriteLine(vetor[cont]);
            cont++;
        }*/

        /* int valorMin = 1;
        int cont = 100;

        while (cont >= valorMin)
        {
            Console.WriteLine(cont);
            cont--;
        }*/

        Console.WriteLine(".................................");
        Console.WriteLine("        $ Bank of Banks $        ");
        Console.WriteLine(".................................");

        int count = 1;
        char answer = 'y';

        while (answer == 'y')
        {
            Console.WriteLine();
            Console.WriteLine("Procedure: " + count);
            Console.WriteLine(".................................");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your balance: $");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"The client's name is {name} and your balance is $ {balance}.");
            Console.WriteLine("Do you want to continue? [Y/N]");
            answer = char.Parse(Console.ReadLine());
            count++;
        }
            
    }

}

