using Axis.Interfaces;
using Axis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.IO;
using System.Text.RegularExpressions;

namespace Axis
{
    public class NameSorter : INameSorter
    {
        /// <summary>
        /// Reads a CSV file for a list of names, and returns the list.
        /// </summary>
        public IList<Name> ReadNamesFromCsv(string filePath)
        {
            // Validation here isn't exhaustive, but I've put it in to be able to test for exceptions 
            // and also to show different tests for full coverage.
            if (!File.Exists(filePath))
            {
                throw new ArgumentException("Input file doesn't exist.");
            }

            var matches = Regex.Matches(File.ReadAllText(filePath), "(\\w+),(\\w+)", RegexOptions.Multiline);

            var names = new List<Name>();
            matches.ToList().ForEach(match =>
            {
                names.Add(new Name
                {
                    FirstName = match.Groups[1].Value,
                    LastName = match.Groups[2].Value
                });
            });

            return names;
        }

        /// <summary>
        /// Takes a list of names, and returns it sorted by name.
        /// </summary>
        public IList<Name> SortNames(IList<Name> names)
        {
            return names.OrderBy(n => n.FirstName).ToList();
        }


    }
}
