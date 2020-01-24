using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFHelper.Filtering;
using EFHelper.MiscClass;

namespace EFHelper.RepositoryList
{
    public class RepoListQueryable : InterfaceRepoListQueryable
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoListQueryable instance;
        public static RepoListQueryable GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoListQueryable();
                return instance;
            }
        }
        public EFReturnValue ListDataQueryable<TResult>(IQueryable<TResult> queryable) where TResult : class
        {            
            try
            {
                QueryGenerator query = new QueryGenerator();
                queryable = query.QueryGeneratorList<TResult>(queryable, null, string.Empty, false, 0);
                var result = queryable.AsEnumerable();
                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
            }
            catch (Exception ex) { string a = ex.ToString(); }

            return eFReturn;
        }

        public EFReturnValue ListDataQueryable<TResult>(IQueryable<TResult> queryable, List<SearchField> searchFieldList) where TResult : class
        {
            try
            {
                QueryGenerator query = new QueryGenerator();
                queryable = query.QueryGeneratorList<TResult>(queryable, searchFieldList, string.Empty, false, 0);
                var result = queryable.AsEnumerable();
                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
            }
            catch (Exception ex) { string a = ex.ToString(); }

            return eFReturn;
        }

        public EFReturnValue ListDataQueryable<TResult>(IQueryable<TResult> queryable, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TResult : class
        {
            try
            {
                QueryGenerator query = new QueryGenerator();
                queryable = query.QueryGeneratorList<TResult>(queryable, searchFieldList, sortColumn,isAscending,topTake);
                var result = queryable.AsEnumerable();
                eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
            }
            catch (Exception ex) { string a = ex.ToString(); }

            return eFReturn;
        }
    }
}
