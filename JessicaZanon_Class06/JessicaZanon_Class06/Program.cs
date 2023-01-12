using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("-*-*-*-*- Zanon Store -*-*-*-*-");

        string clientName;
        float balance;
        string product;
        float price;
        float remainingBalance;

        clientName = "Giancarlo Pelone";
        balance = 1250.50f;
        product = "Apple watch";
        price = 800.50f;
        remainingBalance = balance - price;

        Console.WriteLine("Name: " + clientName);
        Console.WriteLine("Balance: $ " + balance);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Price: $ " + price);
        Console.WriteLine("Remaining balance: $ " + remainingBalance);
        Console.ReadLine();

    }

}

