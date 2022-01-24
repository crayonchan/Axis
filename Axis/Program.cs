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
            var sortedNames = sorter.SortNames(names);

            sortedNames.ToList().ForEach(name =>
            {
                Console.WriteLine($"{name.FirstName} {name.LastName}");
            });            
        }
    }
}
