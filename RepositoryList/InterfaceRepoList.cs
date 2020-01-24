using EFHelper.Filtering;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryList
{
    public interface InterfaceRepoList
    {
        EFReturnValue ListData<T>() where T : class;
        EFReturnValue ListData<T>(List<SearchField> searchFieldList) where T : class;
        EFReturnValue ListData<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class;
        EFReturnValue ListData<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TSource : class where TResult : class;
    }
    public interface InterfaceRepoListAsync
    {
        Task<EFReturnValue> ListDataAsync<T>() where T : class;
        Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList) where T : class;
        Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class;
        Task<EFReturnValue>ListDataAsync<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TSource : class where TResult : class;

    }
    public interface InterfaceRepoListQueryable
    {
        EFReturnValue ListDataQueryable<TResult>(IQueryable<TResult> queryable) where TResult : class;
        EFReturnValue ListDataQueryable<TResult>(IQueryable<TResult> queryable,List<SearchField> searchFieldList) where TResult : class;
        EFReturnValue ListDataQueryable<TResult>(IQueryable<TResult> queryable,List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TResult : class;
    }
    public interface InterfaceRepoListQueryableAsync
    {
        Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable) where TResult : class;
        Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable,List<SearchField> searchFieldList) where TResult : class;
        Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable,List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TResult : class;
    }
}
