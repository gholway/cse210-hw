using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Customer person1 = new Customer();
        string result = person1.person();
        Console.WriteLine(result);
        string pause = Console.ReadLine();
        Console.WriteLine(pause);
    }
}
public class Order
{
    public string Recipt()
    {
        List<string> items = new List<string>();
        string repeat = "";
        while(repeat != "stop")
        {
            Product item = new Product();
            string dodad = item.Thing();
            items.Add(dodad);
            Console.WriteLine("Enter ''stop'' to exit or press enter to continue.");
            repeat = Console.ReadLine();
        }
        string print = string.Join("",items);
        return print;
    }
}
public class Product
{
    public string Thing()
    {
        Console.WriteLine("Enter item.");
        string item = Console.ReadLine();
        Console.WriteLine("Enter price");
        float price = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter quantity");
        int quantity = Int32.Parse(Console.ReadLine());
        price = price * quantity;
        string format = item + " x" + quantity + "\n$" + price;
        return format;
    }
}
public class Customer
{
    public string person()
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();
        Address location = new Address();
        string saddress = location.place();
        Order collection = new Order();
        string finishedRecipt = collection.Recipt();
        string printed = finishedRecipt + "\n For: " + name + "\nAt: " + saddress;
        return printed;
    }
}
public class Address
{
    public string place()
    {
        Console.WriteLine("Enter address");
        string saddress = Console.ReadLine();
        Console.WriteLine("Is this a US address enter ''y'' if yes");
        string postal = Console.ReadLine();
        if(postal == "y")
        {
            saddress = saddress + "\n$5";
        }
        else
        {
            saddress = saddress + "\n$35";
        }
        return saddress;
    }
}