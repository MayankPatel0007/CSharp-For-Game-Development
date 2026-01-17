// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int age = 30;
Console.WriteLine(age == 35);//check and return bool
Console.WriteLine(age = 30);//assign value
if (age >= 30 || age >=20) //compare and return bool
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}
string name = "hit";
switch(name)//switch case
{
    case "hi":
        Console.WriteLine(true);
        break;
    case "no":
        Console.WriteLine(false); 
        break;
    default:
        Console.WriteLine("Default");
        break;
}