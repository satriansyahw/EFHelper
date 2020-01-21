using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.Filtering;
using EFHelper.RepositoryList;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.RepositoryDeleteHeaderDetail
{
    public class RepoDeleteHeaderDetail : InterfaceDeleteHeaderDetail
    {
        public virtual bool DeleteHeaderDetail<T, T1>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            int hasil = 0;
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);

                            context.Set<T>().Remove(entity);
                            context.Set<List<T1>>().Remove(listEntity1);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }

                }
            }

            return hasil > 0 ? true : false;
        }
        
        public virtual bool DeleteHeaderDetail<T, T1, T2>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            int hasil = 0;
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.getListData<T2>(IDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);

                            context.Set<T>().Remove(entity);
                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }

                }
            }

            return hasil > 0 ? true : false;
        }

        public virtual bool DeleteHeaderDetail<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0;
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.getListData<T2>(IDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.getListData<T3>(IDIdentity, idReferenceColName);

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
                        }
                        catch { contextTrans.Rollback(); }
                    }

                }
            }

            return hasil > 0 ? true : false;
        }

        public virtual bool DeleteHeaderDetail<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0;
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.getListData<T2>(IDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.getListData<T3>(IDIdentity, idReferenceColName);
                            List<T4> listEntity4 = this.getListData<T4>(IDIdentity, idReferenceColName);

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
                        }
                        catch { contextTrans.Rollback(); }
                    }

                }
            }

            return hasil > 0 ? true : false;
        }

        public virtual bool DeleteHeaderDetail<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0;
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);
                            List<T2> listEntity2 = this.getListData<T2>(IDIdentity, idReferenceColName);
                            List<T3> listEntity3 = this.getListData<T3>(IDIdentity, idReferenceColName);
                            List<T4> listEntity4 = this.getListData<T4>(IDIdentity, idReferenceColName);
                            List<T5> listEntity5 = this.getListData<T5>(IDIdentity, idReferenceColName);

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
                        }
                        catch { contextTrans.Rollback(); }
                    }

                }
            }

            return hasil > 0 ? true : false;
        }
        private List<T> getListData<T>(int IDIdentity, string idReferenceColName) where T : class
        {
            List<SearchField> param = new System.Collections.Generic.List<SearchField>();
            param.Add(new SearchField { Name = idReferenceColName, Operator = "=", Value = IDIdentity.ToString() });
            RepoList list = new RepoList();
            var myList = list.ListData<T>(param);
            return myList != null ? (List<T>)myList : null;
        }
    }
}
