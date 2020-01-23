using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.MiscClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.RepositoryDelete
{
    public class RepoDeleteList : InterfaceRepoDeleteList
    {
        EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };

        public virtual EFReturnValue DeleteList<T>(List<T> listEntity) where T : class
        {         
            int hasil = 0;
            if (listEntity.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            context.Set<List<T>>().Attach(listEntity);
                            context.Set<List<T>>().Remove(listEntity);
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn; 
        }             
        public virtual EFReturnValue DeleteList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0;
            if (listEntity1.Count > 0 & listEntity2.Count > 0 )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);


                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
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
            int hasil = 0;
            if (listEntity1.Count > 0 & listEntity2.Count > 0 & listEntity3.Count > 0 )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);

                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);
                            context.Set<List<T3>>().Remove(listEntity3);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
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
            int hasil = 0;
            if (listEntity1.Count > 0 & listEntity2.Count > 0 & listEntity3.Count > 0 & listEntity4.Count > 0 )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);

                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);
                            context.Set<List<T3>>().Remove(listEntity3);
                            context.Set<List<T4>>().Remove(listEntity4);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3, listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
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
            int hasil = 0;
            if (listEntity1.Count > 0 & listEntity2.Count > 0 & listEntity3.Count > 0 & listEntity4.Count > 0 & listEntity5.Count > 0)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);
                            context.Set<List<T5>>().Attach(listEntity5);

                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);
                            context.Set<List<T3>>().Remove(listEntity3);
                            context.Set<List<T4>>().Remove(listEntity4);
                            context.Set<List<T5>>().Remove(listEntity5);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteList<T>(List<int> listIDIdentity) where T : class
        {
            int hasil = 0;
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
                            context.Set<List<T>>().Attach(listEntity);
                            context.Set<List<T>>().Remove(listEntity);
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual EFReturnValue DeleteList<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0;
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

                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);

                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
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
            int hasil = 0;
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

                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);

                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);
                            context.Set<List<T3>>().Remove(listEntity3);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
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
            int hasil = 0;
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

                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);

                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);
                            context.Set<List<T3>>().Remove(listEntity3);
                            context.Set<List<T4>>().Remove(listEntity4);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3, listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
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
            int hasil = 0;
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

                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);
                            context.Set<List<T5>>().Attach(listEntity5);

                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);
                            context.Set<List<T3>>().Remove(listEntity3);
                            context.Set<List<T4>>().Remove(listEntity4);
                            context.Set<List<T5>>().Remove(listEntity5);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
 
    }
   
}
