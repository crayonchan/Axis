using Axis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Axis.Interfaces
{
    public interface INameSorter
    {
        IList<Name> ReadNamesFromCsv(string data);
        IList<Name> SortNames(IList<Name> names);
    }
}
