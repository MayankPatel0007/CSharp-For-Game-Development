namespace ARRAYS_AND_LIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] num = new int[5];//intialize with size bydefault value is zero
            int[] sec;//here its not intialize because it dont hsvr size
            Console.WriteLine(num[4]);
            //Console.WriteLine(sec[5]); give error

            Console.WriteLine(System.Array.IndexOf(num, 0));//static methods for index

            Console.WriteLine(num.Length);//length of array

            List<int> arrayList = new List<int>();//declare of List

            Console.WriteLine(arrayList.Count);//count elements same as Length in array
            arrayList.Add(12);
            Console.WriteLine(arrayList.Count);
            arrayList.RemoveAt(0);//remove at index
            arrayList.Insert(0, 13);//index and item
            Console.WriteLine(arrayList.Contains(13));
        }
    }
}