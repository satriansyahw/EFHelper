using System;
using System.Collections.Generic;
using System.Text;
using EFHelper.Filtering;

namespace EFHelper.EntityPreparation
{
    public class ListGenerator : InterfaceListGenerator
    {
        public IEnumerable<T> QueryListGenerator<T>(List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake) where T : class
        {
            return null;
            //using (var context = GetDbContext())
            //{
            //    var queryable = context.Set<T>().AsQueryable();
            //    string ha = queryable.ToString();
            //    queryable = FilterLinq.QueryGeneratorList<T>(queryable, SearchFieldList, sortColumn, isascending, toptake);
            //    result = await queryable.ToListAsync();
            //}
        }
    }
}
