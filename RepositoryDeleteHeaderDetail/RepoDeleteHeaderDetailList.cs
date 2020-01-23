using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryList;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.RepositoryDeleteHeaderDetail
{
    public class RepoDeleteHeaderDetailList : InterfaceDeleteHeaderDetailList
    {
        EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };

        public virtual EFReturnValue DeleteHeaderDetailList<T, T1>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            int hasil = 0;
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

                            List<T1> listEntity1 = this.getListData<T1>(listIDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);

                            context.Set<T>().Remove(entity);
                            context.Set<List<T1>>().Remove(listEntity1);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
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
            int hasil = 0;
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
                            List<T1> listEntity1 = this.getListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.getListData<T2>(listIDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);

                            context.Set<T>().Remove(entity);
                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
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
            int hasil = 0;
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
                            List<T1> listEntity1 = this.getListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.getListData<T2>(listIDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.getListData<T3>(listIDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);

                            context.Set<T>().Remove(entity);
                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);
                            context.Set<List<T3>>().Remove(listEntity3);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2, listEntity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
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
            int hasil = 0;
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
                            List<T1> listEntity1 = this.getListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.getListData<T2>(listIDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.getListData<T3>(listIDIdentity, idReferenceColName);
                            List<T4> listEntity4 = this.getListData<T4>(listIDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);

                            context.Set<T>().Remove(entity);
                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);
                            context.Set<List<T3>>().Remove(listEntity3);
                            context.Set<List<T4>>().Remove(listEntity4);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2, listEntity3, listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
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
            int hasil = 0;
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
                            List<T1> listEntity1 = this.getListData<T1>(listIDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.getListData<T2>(listIDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.getListData<T3>(listIDIdentity, idReferenceColName);
                            List<T4> listEntity4 = this.getListData<T4>(listIDIdentity, idReferenceColName);
                            List<T5> listEntity5 = this.getListData<T5>(listIDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);
                            context.Set<List<T5>>().Attach(listEntity5);

                            context.Set<T>().Remove(entity);
                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);
                            context.Set<List<T3>>().Remove(listEntity3);
                            context.Set<List<T4>>().Remove(listEntity4);
                            context.Set<List<T5>>().Remove(listEntity5);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }

        private List<T> getListData<T>(List<int> listIDIdentity, string idReferenceColName) where T : class
        {
            List<SearchField> param = new System.Collections.Generic.List<SearchField>();
            param.Add(new SearchField { Name = idReferenceColName, Operator = "in", Value = listIDIdentity });
            RepoList list = new RepoList();
            var myList = list.ListData<T>(param);
             return (myList.IsSuccessConnection & myList.IsSuccessQuery  & ((List<T>)myList.ReturnValue).Count > 0) ? (List<T>)myList.ReturnValue : null;
        }
    }
}
