// See https://aka.ms/new-console-template for more information
using DesignPatternsSolidPriciples.Encapsulation;

//Console.WriteLine("Hello, World!");

//BadBankAcount ba=new BadBankAcount();

//ba.balance = 500;

//Console.WriteLine(ba.balance);


BankAccount account=new BankAccount(100);

Console.WriteLine(account.GetBalance());


account.Deposit(500);

Console.WriteLine(account.GetBalance());

account.WithDraw(150);

Console.WriteLine(account.GetBalance());