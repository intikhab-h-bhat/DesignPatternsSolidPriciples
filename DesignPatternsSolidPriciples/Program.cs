// See https://aka.ms/new-console-template for more information
using DesignPatternsSolidPriciples.Abstraction;
using DesignPatternsSolidPriciples.Encapsulation;

Console.WriteLine("*******************************Abstraction Demo******************************");

AbstractionDemo at = new  AbstractionDemo();
at.SendEmail();
//at.Authenticate();
//at.ConnectServer();
//at.DisConnect();

Car uab= new Car();

uab.Start();
uab.Stop();





//Console.WriteLine("*******************Encapsulation Demo!***************");

//BadBankAcount ba=new BadBankAcount();

//ba.balance = 500;

//Console.WriteLine(ba.balance);


//BankAccount account=new BankAccount(100);

//Console.WriteLine(account.GetBalance());


//account.Deposit(500);

//Console.WriteLine(account.GetBalance());

//account.WithDraw(150);

//Console.WriteLine(account.GetBalance());