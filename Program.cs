using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello "+name+"!!" );
            foreach(int i in arr)
            {
                if(i%2==0)
                    Console.WriteLine("Even num: "+i);
            }
            
        }
    }
   
}
