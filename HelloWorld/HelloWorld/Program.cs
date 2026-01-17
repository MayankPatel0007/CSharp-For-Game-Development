// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Asshole");

int age=0 ;//we also  dont need need to assign value
Console.WriteLine(age);

age = age + 1;//can modify
age++;//only bt one
age += 1;//can modify
Console.WriteLine(age+" hi!");//use different  types of data type and operation and merge using '+'
Console.WriteLine("Hi");

float b = 1.5f;
Console.WriteLine(b);
age = int.MaxValue;
Console.WriteLine(age);
age = int.MinValue;
Console.WriteLine(age);

string name = "Ass";
Console.WriteLine(name+ " hole");
Console.WriteLine($"{name}hole");//interpolation $ and {}
Console.WriteLine("\"hello\"");

char ch = 'c';
bool nt = true;
var hd = "hello";

Console.WriteLine("Hello "+ 5 + 6 );//associativity left to right so became string

Console.WriteLine(5 + 6 + " Hello");//its act like no and string addition operation act

int ageInt = (int)5.6;
Console.WriteLine(ageInt);
double ac = (double)1/ 10;//explicite typecast also need to type cast any number from divison because its int
Console.WriteLine(ac);