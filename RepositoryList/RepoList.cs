﻿using System;
using System.Collections.Generic;
using System.Linq;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.Filtering;
using EFHelper.MiscClass;

namespace EFHelper.RepositoryList
{
    public class RepoList : InterfaceRepoList
    {       
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoList instance;
        public static RepoList GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoList();
                return instance;
            }
        }
        public virtual EFReturnValue ListData<T>(List<SearchField> searchFieldList) where T : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                try
                {
                    var queryable = context.Set<T>().AsQueryable();
                    QueryGenerator query = new QueryGenerator();
                    queryable = query.QueryGeneratorList<T>(queryable, searchFieldList, string.Empty, false, 0);
                    var result = queryable.AsEnumerable();
                    eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
                }
                catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex); }
            }            
            return eFReturn;
        }
        public virtual EFReturnValue ListData<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                try
                {
                    var queryable = context.Set<T>().AsQueryable();
                    QueryGenerator query = new QueryGenerator();
                    queryable = query.QueryGeneratorList<T>(queryable, searchFieldList,sortColumn,isAscending,topTake);
                    var result = queryable.AsEnumerable();
                    eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
                }
                catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex); }
            }
            return eFReturn;

        }
        public virtual EFReturnValue ListData<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class
            where TResult : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                try
                {
                    var queryable = context.Set<TSource>().AsQueryable();
                    QueryGenerator query = new QueryGenerator();
                    var result = query.QueryGeneratorList<TSource, TResult>(queryable, searchFieldList, sortColumn, false, topTake).AsEnumerable();
                }
                catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex); }
            }
            return eFReturn;

        }

        public virtual EFReturnValue ListData<T>() where T : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                try
                {
                    var queryable = context.Set<T>().AsQueryable();
                    QueryGenerator query = new QueryGenerator();
                    queryable = query.QueryGeneratorList<T>(queryable, null, string.Empty, false, 0);
                    var result = queryable.AsEnumerable();
                    eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, result);
                }
                catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex); }
            }
            return eFReturn;
        }

    }
}
