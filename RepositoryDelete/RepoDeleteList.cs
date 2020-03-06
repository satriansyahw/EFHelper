﻿using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.RepositoryDelete
{
    public class RepoDeleteList : InterfaceRepoDeleteList
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoDeleteList instance;
        public static RepoDeleteList GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoDeleteList();
                return instance;
            }
        }
        public virtual EFReturnValue DeleteList<T>(List<T> listEntity) where T : class
        {         
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            foreach (var item in listEntity) { context.Set<T>().Attach(item); context.Set<T>().Remove(item); }
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn; 
        }             
        public virtual EFReturnValue DeleteList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1.Count > 0 & listEntity2.Count > 0 )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Set<T1>().Remove(item); }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Set<T2>().Remove(item); }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1.Count > 0 & listEntity2.Count > 0 & listEntity3.Count > 0 )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Set<T1>().Remove(item); }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Set<T2>().Remove(item); }
                            foreach (var item in listEntity3) { context.Set<T3>().Attach(item); context.Set<T3>().Remove(item); }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1.Count > 0 & listEntity2.Count > 0 & listEntity3.Count > 0 & listEntity4.Count > 0 )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Set<T1>().Remove(item); }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Set<T2>().Remove(item); }
                            foreach (var item in listEntity3) { context.Set<T3>().Attach(item); context.Set<T3>().Remove(item); }
                            foreach (var item in listEntity4) { context.Set<T4>().Attach(item); context.Set<T4>().Remove(item); }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3, listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntity1.Count > 0 & listEntity2.Count > 0 & listEntity3.Count > 0 & listEntity4.Count > 0 & listEntity5.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Set<T1>().Remove(item); }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Set<T2>().Remove(item); }
                            foreach (var item in listEntity3) { context.Set<T3>().Attach(item); context.Set<T3>().Remove(item); }
                            foreach (var item in listEntity4) { context.Set<T4>().Attach(item); context.Set<T4>().Remove(item); }
                            foreach (var item in listEntity5) { context.Set<T5>().Attach(item); context.Set<T5>().Remove(item); }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteList<T>(List<int> listIDIdentity) where T : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T> listEntity = new List<T>();
                            foreach (var IDIdentity in listIDIdentity)
                            {
                                T entity = Activator.CreateInstance<T>();
                                if (entity != null)
                                {
                                    ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                                    listEntity.Add(entity);
                                }
                            }
                            foreach (var item in listEntity) { context.Set<T>().Attach(item); context.Set<T>().Remove(item); }
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteList<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity1.Count > 0 & listIDIdentity2.Count > 0 )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T1> listEntity1 =  ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T1>(listIDIdentity1);
                            List<T2> listEntity2 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T2>(listIDIdentity2);

                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Set<T1>().Remove(item); }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Set<T2>().Remove(item); }
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteList<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity1.Count > 0 & listIDIdentity2.Count > 0 & listIDIdentity3.Count > 0 )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T1> listEntity1 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T1>(listIDIdentity1);
                            List<T2> listEntity2 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T2>(listIDIdentity2);
                            List<T3> listEntity3 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T3>(listIDIdentity3);

                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Set<T1>().Remove(item); }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Set<T2>().Remove(item); }
                            foreach (var item in listEntity3) { context.Set<T3>().Attach(item); context.Set<T3>().Remove(item); }
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteList<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity1.Count > 0 & listIDIdentity2.Count > 0 & listIDIdentity3.Count > 0 & listIDIdentity4.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T1> listEntity1 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T1>(listIDIdentity1);
                            List<T2> listEntity2 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T2>(listIDIdentity2);
                            List<T3> listEntity3 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T3>(listIDIdentity3);
                            List<T4> listEntity4 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T4>(listIDIdentity4);

                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Set<T1>().Remove(item); }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Set<T2>().Remove(item); }
                            foreach (var item in listEntity3) { context.Set<T3>().Attach(item); context.Set<T3>().Remove(item); }
                            foreach (var item in listEntity4) { context.Set<T4>().Attach(item); context.Set<T4>().Remove(item); }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3, listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteList<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listIDIdentity1.Count > 0 & listIDIdentity2.Count > 0 & listIDIdentity3.Count > 0 & listIDIdentity4.Count > 0 & listIDIdentity5.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<T1> listEntity1 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T1>(listIDIdentity1);
                            List<T2> listEntity2 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T2>(listIDIdentity2);
                            List<T3> listEntity3 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T3>(listIDIdentity3);
                            List<T4> listEntity4 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T4>(listIDIdentity4);
                            List<T5> listEntity5 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T5>(listIDIdentity5);

                            foreach (var item in listEntity1) { context.Set<T1>().Attach(item); context.Set<T1>().Remove(item); }
                            foreach (var item in listEntity2) { context.Set<T2>().Attach(item); context.Set<T2>().Remove(item); }
                            foreach (var item in listEntity3) { context.Set<T3>().Attach(item); context.Set<T3>().Remove(item); }
                            foreach (var item in listEntity4) { context.Set<T4>().Attach(item); context.Set<T4>().Remove(item); }
                            foreach (var item in listEntity5) { context.Set<T5>().Attach(item); context.Set<T5>().Remove(item); }

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
 
    }
   
}
