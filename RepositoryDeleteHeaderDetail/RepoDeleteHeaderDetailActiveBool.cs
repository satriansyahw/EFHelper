﻿using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.Filtering;
using EFHelper.MiscClass;
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
        EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };

        public virtual EFReturnValue DeleteHeaderDetailActiveBool<T, T1>(int IDIdentity, string idReferenceColName)
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

                            entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(entity);
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);

                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate", "updatetime");
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool", "boolactive");
                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("updatedate", "updatetime");
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("activebool", "boolactive");

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);

                            context.Entry(entity).State = EntityState.Unchanged;
                            context.Entry(listEntity1).State = EntityState.Unchanged;

                            context.Entry(entity).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(entity).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity1).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
 
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
        public virtual EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2>(int IDIdentity, string idReferenceColName)
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

                            entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(entity);
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);

                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate", "updatetime");
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool", "boolactive");
                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("updatedate", "updatetime");
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("activebool", "boolactive");
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("updatedate", "updatetime");
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("activebool", "boolactive");

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);

                            context.Entry(entity).State = EntityState.Unchanged;
                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity2).State = EntityState.Unchanged;

                            context.Entry(entity).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(entity).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity1).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity2).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
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
        public virtual EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
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

                            entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(entity);
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);

                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate", "updatetime");
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool", "boolactive");
                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("updatedate", "updatetime");
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("activebool", "boolactive");
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("updatedate", "updatetime");
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("activebool", "boolactive");
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>("updatedate", "updatetime");
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>("activebool", "boolactive");
    
                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            
                            context.Entry(entity).State = EntityState.Unchanged;
                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity2).State = EntityState.Unchanged;
                            context.Entry(listEntity3).State = EntityState.Unchanged;
                            
                            context.Entry(entity).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(entity).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity1).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity2).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity3).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity3).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
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
        public virtual EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
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

                            entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(entity);
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(listEntity4);

                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate", "updatetime");
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool", "boolactive");
                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("updatedate", "updatetime");
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("activebool", "boolactive");
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("updatedate", "updatetime");
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("activebool", "boolactive");
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>("updatedate", "updatetime");
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>("activebool", "boolactive");
                            var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>("updatedate", "updatetime");
                            var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>("activebool", "boolactive");

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);

                            context.Entry(entity).State = EntityState.Unchanged;
                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity2).State = EntityState.Unchanged;
                            context.Entry(listEntity3).State = EntityState.Unchanged;
                            context.Entry(listEntity4).State = EntityState.Unchanged;

                            context.Entry(entity).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(entity).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity1).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity2).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity3).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity3).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity4).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity4).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1,listEntity2,listEntity3,listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
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

                            entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(entity);
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(listEntity4);
                            listEntity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T5>(listEntity5);

                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate", "updatetime");
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool", "boolactive");
                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("updatedate", "updatetime");
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>("activebool", "boolactive");
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("updatedate", "updatetime");
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>("activebool", "boolactive");
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>("updatedate", "updatetime");
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>("activebool", "boolactive");
                            var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>("updatedate", "updatetime");
                            var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>("activebool", "boolactive");
                            var propUpdateDate5 = ColumnPropGet.GetInstance.GetColumnProps<T5>("updatedate", "updatetime");
                            var propActiveBool5 = ColumnPropGet.GetInstance.GetColumnProps<T5>("activebool", "boolactive");

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);
                            context.Set<List<T5>>().Attach(listEntity5);

                            context.Entry(entity).State = EntityState.Unchanged;
                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity2).State = EntityState.Unchanged;
                            context.Entry(listEntity3).State = EntityState.Unchanged;
                            context.Entry(listEntity4).State = EntityState.Unchanged;
                            context.Entry(listEntity5).State = EntityState.Unchanged;

                            context.Entry(entity).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(entity).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity1).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity2).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity3).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity3).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity4).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity4).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;
                            context.Entry(listEntity5).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity5).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;

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

        private List<T> getListData<T>(int IDIdentity, string idReferenceColName) where T : class
        {
            List<SearchField> param = new System.Collections.Generic.List<SearchField>();
            param.Add(new SearchField { Name = idReferenceColName, Operator = "=", Value = IDIdentity.ToString() });
            RepoList list = new RepoList();
            var myList = list.ListData<T>(param);
            return (myList.IsSuccessConnection & myList.IsSuccessQuery  & ((List<T>)myList.ReturnValue).Count > 0) ? (List<T>)myList.ReturnValue : null;
        }
    }
}
