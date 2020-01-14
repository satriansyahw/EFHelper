using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFHelper.EntityPreparation;
using EFHelper.Filtering;
using Microsoft.EntityFrameworkCore;

namespace EFHelper.RepositoryList
{
    public class RepoListAsync : InterfaceRepoListAsync
    {
        ListGenerator list = new ListGenerator();
        public IAsyncEnumerable<T> ListData<T>(List<SearchField> searchFieldList) where T : class
        {
            return list.QueryListGenerator<T>(searchFieldList, string.Empty, false, 0).ToAsyncEnumerable();
        }

        public IAsyncEnumerable<T> ListData<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class
        {
            return list.QueryListGenerator<T>(searchFieldList, sortColumn,isAscending,topTake).ToAsyncEnumerable();
        }
        
        public IAsyncEnumerable<TResult> ListData<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class
            where TResult : class
        {
            return list.QueryListGenerator<TSource,TResult>(searchFieldList, sortColumn, isAscending, topTake).ToAsyncEnumerable();
        }

    }
}
