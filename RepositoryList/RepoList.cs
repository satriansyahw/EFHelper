using System.Collections.Generic;
using System.Linq;
using EFHelper.EntityPreparation;
using EFHelper.Filtering;

namespace EFHelper.RepositoryList
{
    public class RepoList : InterfaceRepoList
    {
        ListGenerator list = new ListGenerator();
        public IEnumerable<T> ListData<T>(List<SearchField> searchFieldList) where T : class
        {
            return list.QueryListGenerator<T>(searchFieldList, string.Empty, false, 0).AsEnumerable();
        }

        public IEnumerable<T> ListData<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class
        {
            return list.QueryListGenerator<T>(searchFieldList, sortColumn, isAscending, topTake).AsEnumerable();
        }
        
        public IEnumerable<TResult> ListData<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class
            where TResult : class
        {
            return list.QueryListGenerator<TSource,TResult>(searchFieldList, sortColumn, isAscending, topTake).AsEnumerable();
        }
    }
}
