using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryList;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;

namespace EFHelper.DBCommandList
{
    public class DBCommandRepoList: InterfaceRepoList
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };

        public virtual EFReturnValue ListData<T>() where T : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var cmd = context.Database.GetDbConnection().CreateCommand())
                {
                    try
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                        if (cmd.Connection.State == ConnectionState.Closed)
                            cmd.Connection.Open();
                        cmd.CommandTimeout = MiscClass.MiscClass.CommandTimeOut;
                        cmd.CommandText = "select " + DBCommandListQuery.GetInstance.CreateQueryList<T>();

                        List<ColumnListInfo> listColumn =  ColumnPropGet.GetInstance.GetColumnList<T>();
                        List<T> listResult = new List<T>();
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                var classEntity = Activator.CreateInstance<T>();
                                foreach (var item in listColumn)
                                {
                                    int ordinal = dataReader.GetOrdinal(item.ColName);
                                    object value = dataReader.GetValue(ordinal);
                                    ColumnPropSet.GetInstance.SetColValue<T>(classEntity, item.ColName, value);
                                }
                                listResult.Add(classEntity);
                            }
                        }
                        eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, listResult);
                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }
                    finally
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue ListData<T>(List<SearchField> searchFieldList) where T : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var cmd = context.Database.GetDbConnection().CreateCommand())
                {
                    try
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                        if (cmd.Connection.State == ConnectionState.Closed)
                            cmd.Connection.Open();
                        cmd.CommandTimeout = MiscClass.MiscClass.CommandTimeOut;
                        var queryResult = DBCommandListQuery.GetInstance.CreateQueryList<T>(searchFieldList);
                        cmd.CommandText = queryResult.SelectQuery;
                        foreach (var sqlParameter in queryResult.ListParameters)
                        {
                            cmd.Parameters.Add(sqlParameter);
                        }

                        List<ColumnListInfo> listColumn = ColumnPropGet.GetInstance.GetColumnList<T>();
                        List<T> listResult = new List<T>();
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            listResult = new List<T>();
                            while (dataReader.Read())
                            {
                                var classEntity = Activator.CreateInstance<T>();
                                foreach (var item in listColumn)
                                {
                                    int ordinal = dataReader.GetOrdinal(item.ColName);
                                    object value = dataReader.GetValue(ordinal);
                                    ColumnPropSet.GetInstance.SetColValue<T>(classEntity, item.ColName, value);
                                }
                                listResult.Add(classEntity);
                            }
                        }
                        eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, listResult);
                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }
                    finally
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue ListData<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var cmd = context.Database.GetDbConnection().CreateCommand())
                {
                    try
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                        if (cmd.Connection.State == ConnectionState.Closed)
                            cmd.Connection.Open();
                        cmd.CommandTimeout = MiscClass.MiscClass.CommandTimeOut;
                        var queryResult = DBCommandListQuery.GetInstance.CreateQueryList<T>(searchFieldList,sortColumn,isAscending,topTake);
                        cmd.CommandText = queryResult.SelectQuery;
                        foreach (var sqlParameter in queryResult.ListParameters)
                        {
                            cmd.Parameters.Add(sqlParameter);
                        }

                        List<ColumnListInfo> listColumn = ColumnPropGet.GetInstance.GetColumnList<T>();
                        List<T> listResult = new List<T>();
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                var classEntity = Activator.CreateInstance<T>();
                                foreach (var item in listColumn)
                                {
                                    int ordinal = dataReader.GetOrdinal(item.ColName);
                                    object value = dataReader.GetValue(ordinal);
                                    ColumnPropSet.GetInstance.SetColValue<T>(classEntity, item.ColName, value);
                                }
                                listResult.Add(classEntity);
                            }
                        }
                        eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, listResult);
                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }
                    finally
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue ListData<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class
            where TResult : class
        {
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var cmd = context.Database.GetDbConnection().CreateCommand())
                {
                    try
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                        if (cmd.Connection.State == ConnectionState.Closed)
                            cmd.Connection.Open();
                        cmd.CommandTimeout = MiscClass.MiscClass.CommandTimeOut;
                        var queryResult = DBCommandListQuery.GetInstance.CreateQueryList<TSource,TResult>(searchFieldList, sortColumn, isAscending, topTake);
                        cmd.CommandText = queryResult.SelectQuery;
                        foreach (var sqlParameter in queryResult.ListParameters)
                        {
                            cmd.Parameters.Add(sqlParameter);
                        }

                        List<ColumnListInfo> listColumn = ColumnPropGet.GetInstance.GetColumnList<TResult>();
                        List<TResult> listResult = new List<TResult>();
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                var classEntity = Activator.CreateInstance<TResult>();
                                foreach (var item in listColumn)
                                {
                                    int ordinal = dataReader.GetOrdinal(item.ColName);
                                    object value = dataReader.GetValue(ordinal);
                                    ColumnPropSet.GetInstance.SetColValue<TResult>(classEntity, item.ColName, value);
                                }
                                listResult.Add(classEntity);
                            }
                        }
                        eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, listResult);
                    }
                    catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); }
                    finally
                    {
                        if (cmd.Connection.State == ConnectionState.Open)
                            cmd.Connection.Close();
                    }
                }
            }
            return eFReturn;
        }
    }
}
