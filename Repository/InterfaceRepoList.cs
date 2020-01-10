using EFHelper.Filtering;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.Repository
{
    public interface InterfaceRepoList
    {
        IEnumerable<T> ListData<T>(List<SearchField> SearchFieldList) where T : class;
        IEnumerable<T> ListData<T>(List<SearchField> SearchFieldList, string sortColumn, bool isAscending, int topTake) where T : class;
        IEnumerable<TResult> ListData<TSource, TResult>(List<SearchField> SearchFieldList, string sortColumn, bool isAscending, int topTake) where TSource : class where TResult : class;
    }
}
