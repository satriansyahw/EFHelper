﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using Microsoft.EntityFrameworkCore;

namespace EFHelper.RepositoryList
{
    public  class RepoListAsync : InterfaceRepoListAsync
    {
        EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };

        public virtual async Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList) where T : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                try
                {
                    var queryable = context.Set<T>().AsQueryable();
                    QueryGenerator query = new QueryGenerator();
                    queryable = query.QueryGeneratorList<T>(queryable, searchFieldList, string.Empty, false, 0);
                    var result = await queryable.ToListAsync();
                    eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
                }
                catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex); }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                try
                {
                    var queryable = context.Set<T>().AsQueryable();
                    QueryGenerator query = new QueryGenerator();
                    queryable = query.QueryGeneratorList<T>(queryable, searchFieldList, sortColumn, isAscending, topTake);
                    var result = await queryable.ToListAsync();
                    eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
                }
                catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex); }
            }
            return eFReturn;

        }
        public virtual async Task<EFReturnValue> ListDataAsync<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class
            where TResult : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                try
                {
                    var queryable = context.Set<TSource>().AsQueryable();
                    QueryGenerator query = new QueryGenerator();
                    var result = await query.QueryGeneratorList<TSource, TResult>(queryable, searchFieldList, sortColumn, false, topTake).ToListAsync();
                    eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
                }
                catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex); }
            }
            return eFReturn;

        }
       
    }
}
