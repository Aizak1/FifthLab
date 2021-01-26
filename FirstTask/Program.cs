using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            bool IsarraySizeANumber = int.TryParse(Console.ReadLine(),out int arraySize);
            if (IsarraySizeANumber)
            {
                float[] initialArray = new float[arraySize];
                for (int i = 0; i < arraySize; i++)
                {
                    Console.WriteLine($"Enter {i+1} element");
                    bool IsElementANumber = float.TryParse(Console.ReadLine(), out float element);
                    if (IsElementANumber)
                        initialArray[i] = element;
                    else
                    {
                        Console.WriteLine("It's not a float number.Try again");
                        i--;
                    }
                }
            }
            
        }
       
        
    }
}
