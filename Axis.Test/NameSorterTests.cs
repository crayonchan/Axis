using Axis.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace Axis.Test
{
    public class NameSorterTests
    {
        [Fact]
        public void Should_Throw_When_File_Does_Not_Exist()
        {
            var sorter = new NameSorter();

            Assert.Throws<ArgumentException>(() =>
            {
                sorter.ReadNamesFromCsv("fakeName.csv");
            });
        }

        [Fact]
        public void Should_Read_All_Lines_In_File()
        {
            var sorter = new NameSorter();
            var list = sorter.ReadNamesFromCsv("Data\\names.csv");

            Assert.Equal(4, list.Count);
        }

        [Fact]
        public void Should_Sort_All_Names_Correctly()
        {
            var testList = new List<Name>
            {
                new Name { FirstName = "C", LastName = "1" },
                new Name { FirstName = "A", LastName = "1" },
                new Name { FirstName = "B", LastName = "1" }
            };

            var sortedList = new NameSorter().SortNames(testList);

            Assert.Equal("A", sortedList[0].FirstName);
            Assert.Equal("B", sortedList[1].FirstName);
            Assert.Equal("C", sortedList[2].FirstName);
        }
    }
}
