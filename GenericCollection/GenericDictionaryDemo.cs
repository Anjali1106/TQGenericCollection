using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class GenericDictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> pair = new Dictionary<int, string>();
           
            pair.Add(1, "a");
            pair.Add(2, "b");
            pair.Add(3, "c");
            pair.Add(4, "d");

            pair.Remove(3);

            foreach (var i in pair)
            {

                Console.WriteLine(i.Key);

            }

            Console.WriteLine("-----------------");


            foreach (KeyValuePair<int, string> item in pair)
            {
                Console.WriteLine(item);
            }

        }

    }
}
