using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arr = { "Pham", "Ngoc", "Sang" };
            Stack myStack = new Stack(3);
            for (int i = 0; i < arr.Length; i++)
            {
                myStack.push(arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = myStack.pop();
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

    }
}
