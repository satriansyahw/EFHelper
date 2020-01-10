using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFHelper.Context;
using EFHelper.Filtering;

namespace EFHelper.Repository
{
    public class ListGenerator : InterfaceListGenerator
    {
        public IQueryable<T> QueryListGenerator<T>(List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake) where T : class
        {
            IQueryable<T> result = null;
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                var queryable = context.Set<T>().AsQueryable();
                QueryGenerator query = new QueryGenerator();
                queryable = query.QueryGeneratorList<T>(queryable, SearchFieldList, sortColumn, false, toptake);
                result =  queryable;
            }
            return result;

        }

        public IQueryable<TResult> QueryListGenerator<TSource, TResult>(List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake)
            where TSource : class
            where TResult : class
        {
            IQueryable<TResult> result = null;
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                var queryable = context.Set<TSource>().AsQueryable();
                QueryGenerator query = new QueryGenerator();
                result = query.QueryGeneratorList<TSource,TResult>(queryable, SearchFieldList, sortColumn, false, toptake);
            }
            return result;
        }
    }
}
