﻿using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryList;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.RepositoryDeleteHeaderDetail
{
    public class RepoDeleteHeaderDetailList : InterfaceRepoDeleteHeaderDetailList
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoDeleteHeaderDetailList instance;
        public static RepoDeleteHeaderDetailList GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoDeleteHeaderDetailList();
                return instance;
            }
        }
        public virtual EFReturnValue DeleteHeaderDetailList<T, T1>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, listIDIdentity);

                            List<T1> listEntity1 = this.GetListData<T1>(listIDIdentity, idReferenceColName);
                            context.Set<T>().Attach(entity); context.Set<T>().Remove(entity);
                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Set<T1>().Remove(item); }
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }        
        public virtual EFReturnValue DeleteHeaderDetailList<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, listIDIdentity);
                            List<T1> listEntity1 = this.GetListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.GetListData<T2>(listIDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity); context.Set<T>().Remove(entity);
                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Set<T1>().Remove(item); }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Set<T2>().Remove(item); }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteHeaderDetailList<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, listIDIdentity);
                            List<T1> listEntity1 = this.GetListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.GetListData<T2>(listIDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.GetListData<T3>(listIDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity); context.Set<T>().Remove(entity);
                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Set<T1>().Remove(item); }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Set<T2>().Remove(item); }
                            foreach (var item in listEntity3) { context.Set<T3>().Attach(item); context.Set<T3>().Remove(item); }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2, listEntity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteHeaderDetailList<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, listIDIdentity);
                            List<T1> listEntity1 = this.GetListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.GetListData<T2>(listIDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.GetListData<T3>(listIDIdentity, idReferenceColName);
                            List<T4> listEntity4 = this.GetListData<T4>(listIDIdentity, idReferenceColName);
                            context.Set<T>().Attach(entity); context.Set<T>().Remove(entity);
                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Set<T1>().Remove(item); }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Set<T2>().Remove(item); }
                            foreach (var item in listEntity3) { context.Set<T3>().Attach(item); context.Set<T3>().Remove(item); }
                            foreach (var item in listEntity4) { context.Set<T4>().Attach(item); context.Set<T4>().Remove(item); }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2, listEntity3, listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteHeaderDetailList<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, listIDIdentity);
                            List<T1> listEntity1 = this.GetListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.GetListData<T2>(listIDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.GetListData<T3>(listIDIdentity, idReferenceColName);
                            List<T4> listEntity4 = this.GetListData<T4>(listIDIdentity, idReferenceColName);
                            List<T5> listEntity5 = this.GetListData<T5>(listIDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity); context.Set<T>().Remove(entity);
                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Set<T1>().Remove(item); }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Set<T2>().Remove(item); }
                            foreach (var item in listEntity3) { context.Set<T3>().Attach(item); context.Set<T3>().Remove(item); }
                            foreach (var item in listEntity4) { context.Set<T4>().Attach(item); context.Set<T4>().Remove(item); }
                            foreach (var item in listEntity5) { context.Set<T5>().Attach(item); context.Set<T5>().Remove(item); }


                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }

        private List<T> GetListData<T>(List<int> listIDIdentity, string idReferenceColName) where T : class
        {
            List<SearchField> param = new System.Collections.Generic.List<SearchField>
            {
                new SearchField { Name = idReferenceColName, Operator = "in", Value = listIDIdentity }
            };
            RepoList list = new RepoList();
            var myList = list.ListData<T>(param);
            var myListData= (List<T>)myList.ReturnValue[0].ReturnValue;           
             return (myList.IsSuccessConnection & myList.IsSuccessQuery  & myListData.Count > 0) ? myListData : null;
        }
    }
}
