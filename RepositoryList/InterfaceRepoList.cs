using EFHelper.Filtering;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryList
{
    public interface InterfaceRepoList
    {
        EFReturnValue ListData<T>(List<SearchField> searchFieldList) where T : class;
        EFReturnValue ListData<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class;
        EFReturnValue ListData<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TSource : class where TResult : class;
    }
    public interface InterfaceRepoListAsync
    {
        Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList) where T : class;
        Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class;
        Task<EFReturnValue>ListDataAsync<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TSource : class where TResult : class;

    }
}
