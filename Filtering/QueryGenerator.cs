using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFHelper.Filtering
{
    public class QueryGenerator : InterfaceQueryGenerator
    {
        public IQueryable<T> QueryGeneratorList<T>(IQueryable<T> queryable, List<SearchField> SearchFieldList, string sortColumn, bool isascending = false, int toptake = 100)
        {
            throw new NotImplementedException();
        }
    }

}
