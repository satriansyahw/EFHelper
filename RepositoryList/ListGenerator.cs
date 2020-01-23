using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFHelper.Context;
using EFHelper.Filtering;

namespace EFHelper.RepositoryList
{
    public  class ListGenerator : InterfaceListQueryable
    {
        public virtual IQueryable<T> QueryListGenerator<T>(List<SearchField> SearchFieldList, string sortColumn, bool isAscending, int topTake) where T : class
        {
            IQueryable<T> result = null;
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                var queryable = context.Set<T>().AsQueryable();
                QueryGenerator query = new QueryGenerator();
                queryable = query.QueryGeneratorList<T>(queryable, SearchFieldList, sortColumn, false, topTake);
                result =  queryable;
            }
            return result;

        }
        public virtual IQueryable<TResult> QueryListGenerator<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class
            where TResult : class
        {
            IQueryable<TResult> result = null;
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                var queryable = context.Set<TSource>().AsQueryable();
                QueryGenerator query = new QueryGenerator();
                result = query.QueryGeneratorList<TSource,TResult>(queryable, searchFieldList, sortColumn, false, topTake);
            }
            return result;
        }
    }
}
