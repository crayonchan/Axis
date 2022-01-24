using System;
using System.IO;
using System.Linq;

namespace Axis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sorter = new NameSorter();
            var names = sorter.ReadNamesFromCsv("Data\\names.csv");
            names = sorter.SortNames(names);

            names.ToList().ForEach(name =>
            {
                Console.WriteLine($"{name.FirstName} {name.LastName}");
            });            
        }
    }
}
