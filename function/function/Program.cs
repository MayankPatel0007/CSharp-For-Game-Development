namespace function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SayHello("Maynak",19);
            SayHello("Rahul",20);//passign parameter 
            Console.WriteLine(AddNumber(2, 3));
            int num=AddNumber(2, 3, 4);
            Console.WriteLine(num);
            Console.WriteLine($"given number is {IsPositive(-1)}");

            int age = 35;
            SayHello("cant change variable of main function ,it's a copy", age);
            Console.WriteLine(age);
        }

        static void SayHello(string playerNmae,int age)//function need static?
        {
            age++;//only changed in this funxtion because its a copy which passed and new var
            Console.WriteLine($"hello! {playerNmae} , your age is {age}");
        }//return nothing

        static int AddNumber(int x,int y)
        {
            return x + y; 
        }
        static int AddNumber(int x, int y,int z)//more parameters//function overloading
        {
            return x + y;
        }
        static bool IsPositive(int x)//booolean function
        {
            return (x >= 0);
  
        }
    }
}
/* funvtion scope only in {} => which is block.
 inner block can use outer block variable.
but outer can`t
can use in nested inner block;
if you declare class field/variable than within class  than access in any function and any blocks which can be modify*/