using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.Filtering;
using EFHelper.RepositoryList;
using EFHelper.TypeHelper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.RepositoryDeleteHeaderDetail
{
    public class RepoDeleteHeaderDetailActiveBool : InterfaceDeleteHeaderDetailActiveBool
    {
        public virtual bool DeleteHeaderDetailActiveBool<T, T1>(int IDIdentity, string idReferenceColName)
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
                            TypeBantuan tipe = new TypeBantuan();
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate","updatetime");                            
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool","boolactive");                            
                            context.Set<T>().Attach(entity);
                            context.Entry(entity).State = EntityState.Unchanged;
                            context.Entry(entity).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(entity).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;

                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);
                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("updatedate","updatetime");                            
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("activebool","activebool");
                            
                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity1).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;

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

        public virtual bool DeleteHeaderDetailActiveBool<T, T1, T2>(int IDIdentity, string idReferenceColName)
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
                            TypeBantuan tipe = new TypeBantuan();
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate", "updatetime");
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool", "boolactive");

                            context.Set<T>().Attach(entity);
                            context.Entry(entity).State = EntityState.Unchanged;
                            context.Entry(entity).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(entity).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;

                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);
                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("updatedate","updatetime");
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("activebool","boolactive");
                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity1).Property(propUpdateDate1.Name).IsModified = propUpdateDate1 != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool1.Name).IsModified = propActiveBool1 != null ? true : false;

                            List<T2> listEntity2 = this.getListData<T2>(IDIdentity, idReferenceColName);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("updatedate","updatetime");
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("activebool","boolactive");
                            context.Entry(listEntity2).State = EntityState.Unchanged;
                            context.Entry(listEntity2).Property(propUpdateDate2.Name).IsModified = propUpdateDate2 != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool2.Name).IsModified = propActiveBool2 != null ? true : false;

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

        public virtual bool DeleteHeaderDetailActiveBool<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
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
                            TypeBantuan tipe = new TypeBantuan();
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate", "updatetime");
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool", "boolactive");

                            context.Set<T>().Attach(entity);
                            context.Entry(entity).State = EntityState.Unchanged;
                            context.Entry(entity).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(entity).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;

                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);
                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("updatedate","updatetime");
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("activebool","boolactive");
                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity1).Property(propUpdateDate1.Name).IsModified = propUpdateDate1 != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool1.Name).IsModified = propActiveBool1 != null ? true : false;

                            List<T2> listEntity2 = this.getListData<T2>(IDIdentity, idReferenceColName);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("updatedate","updatetime");
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("activebool","boolactive");
                            context.Entry(listEntity2).State = EntityState.Unchanged;
                            context.Entry(listEntity2).Property(propUpdateDate2.Name).IsModified = propUpdateDate2 != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool2.Name).IsModified = propActiveBool2 != null ? true : false;

                            List<T3> listEntity3 = this.getListData<T3>(IDIdentity, idReferenceColName);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>("updatedate", "updatetime");
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>("activebool", "boolactive");
                            context.Entry(listEntity3).State = EntityState.Unchanged;
                            context.Entry(listEntity3).Property(propUpdateDate3.Name).IsModified = propUpdateDate3 != null ? true : false;
                            context.Entry(listEntity3).Property(propActiveBool3.Name).IsModified = propActiveBool3 != null ? true : false;

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

        public virtual bool DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
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
                            TypeBantuan tipe = new TypeBantuan();
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate", "updatetime");
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool", "boolactive");

                            context.Set<T>().Attach(entity);
                            context.Entry(entity).State = EntityState.Unchanged;
                            context.Entry(entity).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(entity).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;

                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);
                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("updatedate","updatetime");
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("activebool","boolactive");
                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity1).Property(propUpdateDate1.Name).IsModified = propUpdateDate1 != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool1.Name).IsModified = propActiveBool1 != null ? true : false;

                            List<T2> listEntity2 = this.getListData<T2>(IDIdentity, idReferenceColName);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("updatedate","updatetime");
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("activebool","boolactive");
                            context.Entry(listEntity2).State = EntityState.Unchanged;
                            context.Entry(listEntity2).Property(propUpdateDate2.Name).IsModified = propUpdateDate2 != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool2.Name).IsModified = propActiveBool2 != null ? true : false;

                            List<T3> listEntity3 = this.getListData<T3>(IDIdentity, idReferenceColName);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>("updatedate", "updatetime");
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>("activebool", "boolactive");
                            context.Entry(listEntity3).State = EntityState.Unchanged;
                            context.Entry(listEntity3).Property(propUpdateDate3.Name).IsModified = propUpdateDate3 != null ? true : false;
                            context.Entry(listEntity3).Property(propActiveBool3.Name).IsModified = propActiveBool3 != null ? true : false;


                            List<T4> listEntity4 = this.getListData<T4>(IDIdentity, idReferenceColName);
                            var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>("updatedate", "updatetime");
                            var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>("activebool", "boolactive");
                            context.Entry(listEntity4).State = EntityState.Unchanged;
                            context.Entry(listEntity4).Property(propUpdateDate4.Name).IsModified = propUpdateDate4 != null ? true : false;
                            context.Entry(listEntity4).Property(propActiveBool4.Name).IsModified = propActiveBool4 != null ? true : false;


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

        public virtual bool DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
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
                            TypeBantuan tipe = new TypeBantuan();
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate","updatetime");                            
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool","boolactive");
                            
                            context.Set<T>().Attach(entity);
                            context.Entry(entity).State = EntityState.Unchanged;
                            context.Entry(entity).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(entity).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;

                            List<T1> listEntity1 = this.getListData<T1>(IDIdentity, idReferenceColName);
                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("updatedate","updatetime");                            
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("activebool","boolactive");                            
                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity1).Property(propUpdateDate1.Name).IsModified = propUpdateDate1 != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool1.Name).IsModified = propActiveBool1 != null ? true : false;

                            List<T2> listEntity2 = this.getListData<T2>(IDIdentity, idReferenceColName);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("updatedate","updatetime");                            
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("activebool","boolactive");                            
                            context.Entry(listEntity2).State = EntityState.Unchanged;
                            context.Entry(listEntity2).Property(propUpdateDate2.Name).IsModified = propUpdateDate2 != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool2.Name).IsModified = propActiveBool2 != null ? true : false;

                            List<T3> listEntity3 = this.getListData<T3>(IDIdentity, idReferenceColName);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>("updatedate","updatetime");
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>("activebool","boolactive");
                            context.Entry(listEntity3).State = EntityState.Unchanged;
                            context.Entry(listEntity3).Property(propUpdateDate3.Name).IsModified = propUpdateDate3 != null ? true : false;
                            context.Entry(listEntity3).Property(propActiveBool3.Name).IsModified = propActiveBool3 != null ? true : false;


                            List<T4> listEntity4 = this.getListData<T4>(IDIdentity, idReferenceColName);
                            var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>("updatedate", "updatetime");
                            var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>("activebool", "boolactive");
                            context.Entry(listEntity4).State = EntityState.Unchanged;
                            context.Entry(listEntity4).Property(propUpdateDate4.Name).IsModified = propUpdateDate4 != null ? true : false;
                            context.Entry(listEntity4).Property(propActiveBool4.Name).IsModified = propActiveBool4 != null ? true : false;

                            List<T5> listEntity5 = this.getListData<T5>(IDIdentity, idReferenceColName);
                            var propUpdateDate5 = ColumnPropGet.GetInstance.GetColumnProps<T5>("updatedate", "updatetime");
                            var propActiveBool5 = ColumnPropGet.GetInstance.GetColumnProps<T5>("activebool", "boolactive");
                            context.Entry(listEntity5).State = EntityState.Unchanged;
                            context.Entry(listEntity5).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity5).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;

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
