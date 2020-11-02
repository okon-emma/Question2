using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayInput = new string[9]
            {
                "ZURICH", "ABU DHABI", "AMSTERDAM", "CALIFORNIA", "NEW DELHI",
                "PARIS", "LONDON", "ROME", "NAIROBI"
            };

            IOrderedEnumerable<string> orderedInput = arrayInput.OrderBy(i => i.Length);
            IOrderedEnumerable<string> orderedInput2 = orderedInput.ThenBy(i => i.First());
            List<string> listInput = orderedInput2.ToList();

            foreach(string item in listInput)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
