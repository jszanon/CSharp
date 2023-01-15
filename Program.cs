using System;
using System.Globalization;


class Program
{


    static void Main(string[] args)
    {

        /* Switch Case
        - Verificação de UMA variável.
         Condiciona a execução de um comando a um conjunto de possibilidades
        lógicas relativas a uma mesma variável.*/

        /* int n;
         n = 1;

         switch (n)
         {

             case 1:
                 Console.WriteLine("N == 1");
                 break;
             case 2:
                 Console.WriteLine("N == 2");
                 break;
             case 3:
                 Console.WriteLine("N == 3");
                 break; */

        /*string nome;
        nome = "Maria";

        switch (nome)
        {

            case "João":
                Console.WriteLine("O nome é João");
                break;
            case "Maria":
                Console.WriteLine("O nome é Maria");
                break;
            case "Lucia":
                Console.WriteLine("O nome é Lucia");
                break;*/


        Console.WriteLine("-------------------------------------");
        Console.WriteLine("|       $   Jessica's Bank   $      |");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();
        bool c1, c2, c3;
        int category;

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your balance: $ ");
        double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        c1 = balance > 0 && balance <= 999;
        c2 = balance > 999 && balance <= 9999;
        c3 = balance >= 9999;

        if (c1)
        {
            category = 1;
        }
        else if (c2)
        {
            category = 2;
        }
        else
        {
            category = 3;
        }

        switch (category)
        {
            case 1:
                Console.WriteLine($"Dear {name}, your are entitled to the Popular Card.");
                break;

            case 2:
                Console.WriteLine($"Dear {name}, your are entitled to the Common Card.");
                break;

            case 3:
                Console.WriteLine($"Dear {name}, your are entitled to the Premium Card.");
                break;

        }
        Console.ReadLine();




    }


}
