using EFHelper.Filtering;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.EntityPreparation
{
    public interface InterfaceListGenerator
    {
        IEnumerable<T> QueryListGenerator<T>(List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake) where T : class;
    }
}
