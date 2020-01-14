using EFHelper.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFHelper.RepositoryList
{
    public interface InterfaceListQueryable
    {
        IQueryable<T> QueryListGenerator<T>(List<SearchField> SearchFieldList, string sortColumn, bool isAscending, int topTake) where T : class;
        IQueryable<TResult> QueryListGenerator<TSource, TResult>(List<SearchField> SearchFieldList, string sortColumn, bool isAscending, int topTake) where TSource : class where TResult : class;

    }
}
