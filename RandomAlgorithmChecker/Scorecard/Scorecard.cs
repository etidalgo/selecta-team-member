using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAlgorithmChecker.Scorecard
{
    class Scorecard<T> : Dictionary<T, int>
    {
        public virtual string PrintKey(T key)
        {
            return key.ToString();
        }

        public void PrintCounts()
        {
            var keyColumnWidth = 15;
            var countColumnWidth = 10;
            Console.WriteLine("{0}{1}", "Key".PadRight(keyColumnWidth), "Count".PadLeft(countColumnWidth));
            foreach (var count in this)
            {
                Console.WriteLine("{0}{1}", PrintKey(count.Key).PadRight(keyColumnWidth), count.Value.ToString().PadLeft(countColumnWidth));
            }
        }
    }
}
