using System;
using System.Globalization;
// if/else - Condiciona a execução de um comando a uma proposição lógica.

class Program
{

    static void Main(string[] args)
    {

        //int n1 = 2;
        //int n2 = 3;

        //bool n1MaiorN2 = n1 > n2; //False
        //bool n1MenorN2 = n1 < n2; //True
        //bool n1IgualN2 = (n1 == n2);

        //if (n1 > n2)
        //{
        //    Console.WriteLine("N1 é maior do que N2.");
        //}
        //else if (n1IgualN2)
        //{
        //    Console.WriteLine("N1 é igual a N2.");
        //}
        //else
        //{
        //    Console.WriteLine("N1 é menor do que N2.");
        //}


        //Console.WriteLine(n1MaiorN2);
        //Console.WriteLine(n1MenorN2);
        //Console.ReadLine();

        Console.WriteLine("-*-*-*-*-* Zanon Store *-*-*-*-*-");
        Console.WriteLine();
        Console.WriteLine("-*-*-*-*-* Customer *-*-*-*-*-");
        Console.WriteLine("Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Balance: $ ");
        double balance = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("-*-*-*-*-* Product *-*-*-*-*-");
        Console.WriteLine("Product: ");
        string product = Console.ReadLine();
        Console.WriteLine("Price: $ ");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine();
        double remainingBalance = balance - price;
        double missingValue = price - balance;
        bool sucessfulPurchase = remainingBalance > 0; 

        
        if (sucessfulPurchase)
        {
            Console.WriteLine("Sucessful Purchase.");
            Console.WriteLine("Remaining Balance: $ " + remainingBalance);
        }
        else
        {
            Console.WriteLine("Purchase not made. Insufficient funds.");
            Console.WriteLine("The missing value is $ " + missingValue);
        }
   
        Console.ReadLine();

    }


}    

