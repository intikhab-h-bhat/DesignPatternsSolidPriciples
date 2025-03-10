// See https://aka.ms/new-console-template for more information
using DesignPatternsSolidPriciples.Abstraction;
using DesignPatternsSolidPriciples.compoition;
using DesignPatternsSolidPriciples.Coupling;
using DesignPatternsSolidPriciples.Encapsulation;
using DesignPatternsSolidPriciples.Inheritance;
using DesignPatternsSolidPriciples.Polymorphism;
using DesignPatternsSolidPriciples.SOLID;
using DesignPatternsSolidPriciples.SOLID.I;
using DesignPatternsSolidPriciples.SOLID.L;
using DesignPatternsSolidPriciples.SOLID.O;
using System;



Console.WriteLine("*********************** Solid Principal****************");


//I - Interface Segregation Principle (ISP)
//A class should not be forced to implement interfaces it does not use.

Circle2D c2d= new Circle2D{radius=5};
Console.WriteLine("Circle ");
Console.WriteLine(c2d.Area());

Sphere3D s3d= new Sphere3D{radius=6};
Console.WriteLine("Sphere");
Console.WriteLine(s3d.Area());
Console.Write(s3d.Volume());







// //L - Liskov Substitution Principle (LSP)

// // objects of a super class should be replicable with objects of itsd subclass without affecting the correctness of the program

// NewShapes ns= new NewRectangle{Length=5,Width=10};
// Console.WriteLine(ns.Area);


// NewShapes ns1= new NewSquare{SideLength=5};


// Console.WriteLine(ns1.Area);



//O - Open/Closed Principle (OCP)
//Open for extension and closed for modification

// Rectangle c=new Rectangle();
// c.Length=4;
// c.Width=5;
// c.CalulateArea();



//S-Single Responsibility Principle (SRP)

// User u=new User();
// u.UserEmail="intikhabh@gmail.com";


// UserService us= new UserService();

// us.Register(u);

















// Console.WriteLine(" ********************** Composition********************");
// NewCar car1= new NewCar();
// car1.StartCar();




// Console.WriteLine(" ********************** Coupling********************");


// Order order =new Order(new EmailSender());
// order.PlaceOrder();




// Console.WriteLine("**************Polymorphism*****************");

// //List<Object> shapes = new List<Object>();
// List<Shape> shapes = new List<Shape>();
// shapes.Add(new Square { Name = "Square",Sides=4 });
// shapes.Add(new Line { Name = "Line", Sides = 0 });

// foreach(var s in shapes)
// {
//     //if (s is Square)
//     //{
//     //    var sq = new Square();
//     //    sq.ClosedFig();

//     //}
//     s.ClosedFig();

    
// }




//Console.WriteLine("*****************Inheritance Example************");

//var car=new Car();
//Console.WriteLine(car.Brand = "Toyoto");
//Console.WriteLine(car.NumberOfDoors = 4);
//car.Model = "abc";
//car.Start();
//car.Stop();

//var bike=new Bike();
//Console.WriteLine(bike.Brand = "Hero Honda");
//Console.WriteLine($"Number of wheels:  {bike.NumberOfWheels = 2}");
//bike.Start();

//bike.Stop();








//Console.WriteLine("*******************************Abstraction Demo******************************");

//AbstractionDemo at = new  AbstractionDemo();
//at.SendEmail();
////at.Authenticate();
////at.ConnectServer();
////at.DisConnect();

//Car uab= new Car();

//uab.Start();
//uab.Stop();





// Console.WriteLine("*******************Encapsulation Demo!***************");

// BadBankAcount ba=new BadBankAcount();

// ba.balance = 500;

// Console.WriteLine(ba.balance);


// BankAccount account=new BankAccount(100);

// Console.WriteLine(account.GetBalance());


// account.Deposit(500);

// Console.WriteLine(account.GetBalance());

// account.WithDraw(150);

// Console.WriteLine(account.GetBalance());