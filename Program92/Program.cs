using System;

namespace Program92
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData= Console.ReadLine();
            char letter = Console.ReadLine()[0];
            bool check = false;

            for (int i=0; i<inputData.Length; i++)
           
                if (inputData[i] == letter)
                    check= true;
            Console.WriteLine(check);
        }
    }
}
