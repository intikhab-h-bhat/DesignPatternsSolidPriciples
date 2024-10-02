// See https://aka.ms/new-console-template for more information
using DesignPatternsSolidPriciples.Abstraction;
using DesignPatternsSolidPriciples.Encapsulation;
using DesignPatternsSolidPriciples.Inheritance;



Console.WriteLine("*****************Inheritance Example************");

var car=new Car();
Console.WriteLine(car.Brand = "Toyoto");
Console.WriteLine(car.NumberOfDoors = 4);
car.Model = "abc";
car.Start();
car.Stop();

var bike=new Bike();
Console.WriteLine(bike.Brand = "Hero Honda");
Console.WriteLine($"Number of wheels:  {bike.NumberOfWheels = 2}");
bike.Start();

bike.Stop();
    







//Console.WriteLine("*******************************Abstraction Demo******************************");

//AbstractionDemo at = new  AbstractionDemo();
//at.SendEmail();
////at.Authenticate();
////at.ConnectServer();
////at.DisConnect();

//Car uab= new Car();

//uab.Start();
//uab.Stop();





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