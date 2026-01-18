namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, World!");
            int age=0;//intalize of variable
            Player player = new Player("Hello");//intialize the reference / objects =>custom type
            Console.WriteLine(player);
            player.SayHello();//call through instance not through class or objrcts
            Console.WriteLine(player.name);
            player.name = "Mayank";//assign value to instance variable

            Console.WriteLine(player.name);
            Player sec = new Player("Hell");//new keyword to create object
            Console.WriteLine(sec.name);//not affected by other */

            Player.SayHello();
            new Player("Hello");
            Player.SayHello();
        }

        class Player
        {
            public static string name="000";//its class variable => fields
            public Player(string name)//constructor =>can pass arguments
            {
                //current object name is  equal to passed parameter
                Console.WriteLine("creating player"+name);
            }

            public static void SayHello()//cudtom function in custom types
            {
                Console.WriteLine($"Hello {name}");
            }
        }
    }//static keyword
    /* 
     staic is only for class ,function and field  
     its not available for objects
    inside static function we can not use non static variable or function
    we can use static field inside non static function
     */

    //Access Modifier

    /*
    
    by default its private => only accesible to that class
    public=>can be accsible for everywhere
    Modifier	Accessible where?
public =>	Everywhere
private =>	Same class only
protected=>	Same class + derived classes
internal=>	Same project (assembly)
protected internal=>	Same project OR derived classes
private protected =>	Same class + derived classes in same project

     */
}
