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

Console.WriteLine("Enter your name : ");
var PoliceName = Console.ReadLine();

Console.WriteLine("Enter your occupation : ");
var PoliceOccupation = Console.ReadLine();

Console.WriteLine("Enter your salary : ");
var PoliceSalary = Console.ReadLine();

Console.WriteLine("Enter your tax : ");
var PoliceTax = Console.ReadLine();

var PSalary = decimal.Parse(PoliceSalary);
var PTax = decimal.Parse(PoliceTax);

var Pjob = new Police(PoliceName, PoliceOccupation, PSalary, PTax);
var PJobs = Pjob.WhoIAM();

Console.WriteLine(PJobs);

var Police = Pjob.GetTax();
Console.WriteLine(Police);


Console.WriteLine("========Teacher=========");

Console.WriteLine("Enter your name : ");
var TeacherName = Console.ReadLine();

Console.WriteLine("Enter your occupation : ");
var TeacherOccupation = Console.ReadLine();

Console.WriteLine("Enter your salary : ");
var TeacherSalary = Console.ReadLine();

Console.WriteLine("Enter your tax : ");
var TeacherTax = Console.ReadLine();

var TSalary = decimal.Parse(TeacherSalary);
var TTax = decimal.Parse(TeacherTax);

var Tjob = new Teacher(TeacherName, TeacherOccupation, TSalary, TTax);
var TJobs = Tjob.WhoIAM();

Console.WriteLine(TJobs);

var Teacher = Tjob.GetTax();
Console.WriteLine(Teacher);