using EFHelper.Filtering;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryList
{
    public interface InterfaceRepoList
    {
        IEnumerable<T> ListData<T>(List<SearchField> searchFieldList) where T : class;
        IEnumerable<T> ListData<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class;
        IEnumerable<TResult> ListData<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TSource : class where TResult : class;
    }
    public interface InterfaceRepoListAsync
    {
        IAsyncEnumerable<T> ListData<T>(List<SearchField> searchFieldList) where T : class;
        IAsyncEnumerable<T> ListData<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class;
        IAsyncEnumerable<TResult> ListData<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TSource : class where TResult : class;
    }
}
