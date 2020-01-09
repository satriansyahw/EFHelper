using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.EntityPreparation
{
    public interface InterfaceEntityPreparation
    {
        T SetPreparationEntity<T>(T entity) where T : class;
        List<T> SetPreparationEntity<T>(List<T> listEntity) where T : class;

        // IEnumerable<T> ListGenerator<T>(List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake) where T : class
        // async Task<IEnumerable<T>> ListGeneratorAsync<T>(List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake) where T : class
        // IEnumerable<T> ListGeneratorInnerJoin<T>(List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake, params string[] includes) where T : class
        // async Task<IEnumerable<T>> ListGeneratorInnerJoinAsync<T>(List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake, params string[] includes) where T : class
        // IEnumerable<TResult> ListGeneratorTResult<TSource, TResult>(List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake) where TSource : class where TResult : class
        // async Task<IEnumerable<TResult>> ListGeneratorTResultAsync<TSource, TResult>(List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake) where TSource : class where TResult : class
        // IEnumerable<TResult> ListGeneratorJoinTResult<TResult>(IQueryable<TResult> queryable, List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake) where TResult : class
        // async Task<IEnumerable<TResult>> ListGeneratorJoinTResultAsync<TResult>(IQueryable<TResult> queryable, List<SearchField> SearchFieldList, string sortColumn, bool isascending, int toptake) where TResult : class

        // async Task<List<T>> PrepareEntityForUpdateAsync<T>(List<T> entityCollection) where T : class
        // async Task<T> PrepareEntityForUpdateAsync<T>(T entity) where T : class

        // T PrepareEntityForUpdateNoSelect<T>(T entity) 
        // T PrepareEntityForUpdate<T>(T entity) where T : class

        // async Task<List<T>> PrepareEntityForUpdateAsync<T>(List<T> entityCollection) where T : class
        //Task<T> PrepareEntityForUpdateAsync<T>(T entity)

        // RepoGenPrepareUpdate<T> PrepareEntityForSaveUpdate<T>(T entity) where T : class
        // List<RepoGenPrepareUpdate<T>> PrepareEntityForSaveUpdate<T>(List<T> listEntity) where T : class

        // async Task<RepoGenPrepareUpdate<T>> PrepareEntityForSaveUpdateAsync<T>(T entity) where T : class
        // async Task<List<RepoGenPrepareUpdate<T>>> PrepareEntityForSaveUpdateAsync<T>(List<T> listEntity) where T : class


    }
}
