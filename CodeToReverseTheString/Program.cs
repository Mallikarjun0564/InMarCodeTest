using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeToReverseTheString
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalString = "";
            Console.WriteLine("please enter your string");
            originalString = Convert.ToString(Console.ReadLine());
            if (!string.IsNullOrEmpty(originalString))
            {
                StringBuilder sbReversedString = new StringBuilder();
                char[] stringArray = originalString.ToCharArray();
                int length = stringArray.Length - 1;
                while (length >= 0)
                {
                    sbReversedString.Append(stringArray[length]);
                    length--;
                }
                Console.WriteLine(sbReversedString.ToString());
            }
            Console.ReadLine();
            
        }
    }
}
