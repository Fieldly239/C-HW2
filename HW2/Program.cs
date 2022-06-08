// See https://aka.ms/new-console-template for more information
using HW2;
Console.WriteLine("========Doctor=========");
Console.WriteLine("Enter your name : ");
var myName = Console.ReadLine();

Console.WriteLine("Enter your occupation : ");
var myOccupation = Console.ReadLine();

Console.WriteLine("Enter your salary : ");
var mySalary = Console.ReadLine();

Console.WriteLine("Enter your tax : ");
var myTax = Console.ReadLine();

var Salary = decimal.Parse(mySalary);
var Tax = decimal.Parse(myTax);

var job = new Doctor(myName, myOccupation, Salary, Tax);
var Jobs = job.WhoIAM();


Console.WriteLine(Jobs);

var Doctor = job.GetTax();
Console.WriteLine(Doctor);

Console.WriteLine("========Police=========");

Console.WriteLine("========Teacher=========");