// See https://aka.ms/new-console-template for more information
using DesignPatternsSolidPriciples.Encapsulation;

Console.WriteLine("Hello, World!");

BadBankAcount ba=new BadBankAcount();

ba.balance = 500;

Console.WriteLine(ba.balance);