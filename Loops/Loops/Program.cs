namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> stringArray = new List<string> { "hi","hello","tik"};

            int i = 5;//i=>itterator


            while(i<5)//0 to 4 =>print 5 times =>1 =>FIRST CHECK CONDITION
            {
                Console.WriteLine("Something..."+i);
                i++;//=>2
            }


            do//firdt do then check condition and then do
            {
                Console.WriteLine("do WHILE"+i);
            } while(i<5);


            for(int k=0; k< stringArray.Count;k++)// its bit easy can have increment or decremrnt
            {
                Console.WriteLine(stringArray[k]);//iterate through array or list
            }

            foreach (string name in stringArray)//for each here string name because type of array is string here we not iterate through index
            {
                Console.WriteLine(name);
            }
        }
    }
}
