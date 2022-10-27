using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Pair<S, T>
    {
        internal S Key { get; set; }
        internal T Value { get; set; }
        internal Pair(S key, T value)
        {
            Key = key;
            Value = value;  
        }
        internal void ShowPair()
        {
            Console.WriteLine($"Key = {Key}");
            Console.WriteLine($"Value = {Value}");
        }
    }
}
