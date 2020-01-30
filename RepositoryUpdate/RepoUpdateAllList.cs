using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.MiscClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EFHelper.RepositoryUpdate
{
    public class RepoUpdateAllList : InterfaceRepoUpdateAllList
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoUpdateAllList instance;
        public static RepoUpdateAllList GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoUpdateAllList();
                return instance;
            }
        }
        public virtual EFReturnValue UpdateAllList<T>(List<T> listEntity) where T : class
        {
            int hasil = 0;
            if (listEntity != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            listEntity= EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T>(listEntity);
                            
                            context.Set<List<T>>().Attach(listEntity);
                            context.Entry(listEntity).State = EntityState.Modified;
                           
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn; 
        }

        public virtual EFReturnValue UpdateAllList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0;
            if (listEntity1 != null & listEntity2 !=null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(listEntity2);
                            
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Entry(listEntity1).State = EntityState.Modified;
                            context.Entry(listEntity2).State = EntityState.Modified;

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

        public virtual EFReturnValue UpdateAllList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0;
            if (listEntity1 != null & listEntity2 != null & listEntity3 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(listEntity3);
                            
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);

                            context.Entry(listEntity1).State = EntityState.Modified;
                            context.Entry(listEntity2).State = EntityState.Modified;
                            context.Entry(listEntity3).State = EntityState.Modified;

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

        public virtual EFReturnValue UpdateAllList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0;
            if (listEntity1 != null & listEntity2 != null & listEntity3 != null & listEntity4 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T4>(listEntity4);
                            
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);

                            context.Entry(listEntity1).State = EntityState.Modified;
                            context.Entry(listEntity2).State = EntityState.Modified;
                            context.Entry(listEntity3).State = EntityState.Modified;
                            context.Entry(listEntity4).State = EntityState.Modified;

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

        public virtual EFReturnValue UpdateAllList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0;
            if (listEntity1 != null & listEntity2 != null & listEntity3 != null & listEntity4 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T4>(listEntity4);
                            listEntity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T5>(listEntity5);

                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);
                            context.Set<List<T5>>().Attach(listEntity5);

                            context.Entry(listEntity1).State = EntityState.Modified;
                            context.Entry(listEntity2).State = EntityState.Modified;
                            context.Entry(listEntity3).State = EntityState.Modified;
                            context.Entry(listEntity4).State = EntityState.Modified;
                            context.Entry(listEntity5).State = EntityState.Modified;

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
