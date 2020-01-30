using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.MiscClass;
using EFHelper.TypeHelper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryDelete
{
    public class RepoDeleteActiveBoolListAsync : InterfaceRepoDeleteActiveBoolListAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoDeleteActiveBoolListAsync instance;
        public static RepoDeleteActiveBoolListAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoDeleteActiveBoolListAsync();
                return instance;
            }
        }
        public virtual async Task<EFReturnValue> DeleteActiveBoolListAsync<T>(List<T> listEntity) where T : class
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
                            listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(listEntity);
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);                            
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayActiveBool);
                            
                            context.Set<List<T>>().Attach(listEntity);
                            context.Entry(listEntity).State = EntityState.Unchanged;
                            context.Entry(listEntity).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            context.Entry(listEntity).Property(propActiveBool.Name).IsModified = propActiveBool != null ? true : false;

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                    
                }
            }

            return eFReturn; 
        }
        public virtual async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0;
            if (listEntity1 != null & listEntity2 != null )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);


                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);

                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);

                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity2).State = EntityState.Unchanged;
                            context.Entry(listEntity1).Property(propUpdateDate1.Name).IsModified = propUpdateDate1 != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool1.Name).IsModified = propActiveBool1 != null ? true : false;
                            context.Entry(listEntity2).Property(propUpdateDate2.Name).IsModified = propUpdateDate2 != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool2.Name).IsModified = propActiveBool2 != null ? true : false;

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0;
            if (listEntity1 != null & listEntity2 != null & listEntity3 != null )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);


                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);

                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);

                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity2).State = EntityState.Unchanged;
                            context.Entry(listEntity3).State = EntityState.Unchanged;
                            
                            context.Entry(listEntity1).Property(propUpdateDate1.Name).IsModified = propUpdateDate1 != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool1.Name).IsModified = propActiveBool1 != null ? true : false;
                            context.Entry(listEntity2).Property(propUpdateDate2.Name).IsModified = propUpdateDate2 != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool2.Name).IsModified = propActiveBool2 != null ? true : false;
                            context.Entry(listEntity3).Property(propUpdateDate3.Name).IsModified = propUpdateDate3 != null ? true : false;
                            context.Entry(listEntity3).Property(propActiveBool3.Name).IsModified = propActiveBool3 != null ? true : false;
                            
                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
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
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(listEntity4);

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);


                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);

                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);

                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity2).State = EntityState.Unchanged;
                            context.Entry(listEntity3).State = EntityState.Unchanged;
                            context.Entry(listEntity4).State = EntityState.Unchanged;

                            context.Entry(listEntity1).Property(propUpdateDate1.Name).IsModified = propUpdateDate1 != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool1.Name).IsModified = propActiveBool1 != null ? true : false;
                            context.Entry(listEntity2).Property(propUpdateDate2.Name).IsModified = propUpdateDate2 != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool2.Name).IsModified = propActiveBool2 != null ? true : false;
                            context.Entry(listEntity3).Property(propUpdateDate3.Name).IsModified = propUpdateDate3 != null ? true : false;
                            context.Entry(listEntity3).Property(propActiveBool3.Name).IsModified = propActiveBool3 != null ? true : false;
                            context.Entry(listEntity4).Property(propUpdateDate4.Name).IsModified = propUpdateDate4 != null ? true : false;
                            context.Entry(listEntity4).Property(propActiveBool4.Name).IsModified = propActiveBool4 != null ? true : false;

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listEntity2, listEntity3, listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0;
            if (listEntity1 != null & listEntity2 != null & listEntity3 != null & listEntity4 != null & listEntity5 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(listEntity4);
                            listEntity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T5>(listEntity5);

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate5 = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool5 = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayActiveBool);


                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);
                            context.Set<List<T5>>().Attach(listEntity5);

                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);
                            context.Set<List<T5>>().Attach(listEntity5);

                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity2).State = EntityState.Unchanged;
                            context.Entry(listEntity3).State = EntityState.Unchanged;
                            context.Entry(listEntity4).State = EntityState.Unchanged;
                            context.Entry(listEntity5).State = EntityState.Unchanged;

                            context.Entry(listEntity1).Property(propUpdateDate1.Name).IsModified = propUpdateDate1 != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool1.Name).IsModified = propActiveBool1 != null ? true : false;
                            context.Entry(listEntity2).Property(propUpdateDate2.Name).IsModified = propUpdateDate2 != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool2.Name).IsModified = propActiveBool2 != null ? true : false;
                            context.Entry(listEntity3).Property(propUpdateDate3.Name).IsModified = propUpdateDate3 != null ? true : false;
                            context.Entry(listEntity3).Property(propActiveBool3.Name).IsModified = propActiveBool3 != null ? true : false;
                            context.Entry(listEntity4).Property(propUpdateDate4.Name).IsModified = propUpdateDate4 != null ? true : false;
                            context.Entry(listEntity4).Property(propActiveBool4.Name).IsModified = propActiveBool4 != null ? true : false;
                            context.Entry(listEntity5).Property(propUpdateDate5.Name).IsModified = propUpdateDate5 != null ? true : false;
                            context.Entry(listEntity5).Property(propActiveBool5.Name).IsModified = propActiveBool5 != null ? true : false;

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1,listEntity2,listEntity3,listEntity4,listEntity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteActiveBoolListAsync<T>(List<int> listIDIdentity) where T : class
        {
            int hasil = 0;
            if (listIDIdentity != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {

                            List<T> listEntity = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T>(listIDIdentity);

                            listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(listEntity);

                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayActiveBool);                         

                            context.Set<List<T>>().Attach(listEntity);
                            context.Entry(listEntity).State = EntityState.Unchanged;
                            context.Entry(listEntity).Property(propUpdateDate.Name).IsModified = propUpdateDate != null ? true : false;
                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0;
            if (listIDIdentity1 != null & listIDIdentity2 != null )
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {

                            List<T1> listEntity1 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T1>(listIDIdentity1);
                            List<T2> listEntity2 = ColumnPropGet.GetInstance.GetInstanceWithIDColumnList<T2>(listIDIdentity2);

                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);

                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);

                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity2).State = EntityState.Unchanged;

                            context.Entry(listEntity1).Property(propUpdateDate1.Name).IsModified = propUpdateDate1 != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool1.Name).IsModified = propActiveBool1 != null ? true : false;
                            context.Entry(listEntity2).Property(propUpdateDate2.Name).IsModified = propUpdateDate2 != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool2.Name).IsModified = propActiveBool2 != null ? true : false;

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listIDIdentity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0;
            if (listIDIdentity1 != null & listIDIdentity2 != null & listIDIdentity3 != null)
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

                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);                            

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);                            

                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);                            

                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity2).State = EntityState.Unchanged;
                            context.Entry(listEntity3).State = EntityState.Unchanged;                            

                            context.Entry(listEntity1).Property(propUpdateDate1.Name).IsModified = propUpdateDate1 != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool1.Name).IsModified = propActiveBool1 != null ? true : false;
                            context.Entry(listEntity2).Property(propUpdateDate2.Name).IsModified = propUpdateDate2 != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool2.Name).IsModified = propActiveBool2 != null ? true : false;
                            context.Entry(listEntity3).Property(propUpdateDate3.Name).IsModified = propUpdateDate3 != null ? true : false;
                            context.Entry(listEntity3).Property(propActiveBool3.Name).IsModified = propActiveBool3 != null ? true : false;                           

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listIDIdentity2, listIDIdentity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0;
            if (listIDIdentity1 != null & listIDIdentity2 != null & listIDIdentity3 != null & listIDIdentity4 != null)
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

                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(listEntity4);

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);

                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);

                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity2).State = EntityState.Unchanged;
                            context.Entry(listEntity3).State = EntityState.Unchanged;
                            context.Entry(listEntity4).State = EntityState.Unchanged;

                            context.Entry(listEntity1).Property(propUpdateDate1.Name).IsModified = propUpdateDate1 != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool1.Name).IsModified = propActiveBool1 != null ? true : false;
                            context.Entry(listEntity2).Property(propUpdateDate2.Name).IsModified = propUpdateDate2 != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool2.Name).IsModified = propActiveBool2 != null ? true : false;
                            context.Entry(listEntity3).Property(propUpdateDate3.Name).IsModified = propUpdateDate3 != null ? true : false;
                            context.Entry(listEntity3).Property(propActiveBool3.Name).IsModified = propActiveBool3 != null ? true : false;
                            context.Entry(listEntity4).Property(propUpdateDate4.Name).IsModified = propUpdateDate4 != null ? true : false;
                            context.Entry(listEntity4).Property(propActiveBool4.Name).IsModified = propActiveBool4 != null ? true : false;

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listIDIdentity2, listIDIdentity3, listIDIdentity4, listIDIdentity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0;
            if (listIDIdentity1 != null & listIDIdentity2 != null & listIDIdentity3 != null & listIDIdentity4 != null & listIDIdentity5 != null)
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

                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T4>(listEntity4);
                            listEntity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T5>(listEntity5);

                            var propUpdateDate1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool1 = ColumnPropGet.GetInstance.GetColumnProps<T1>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool2 = ColumnPropGet.GetInstance.GetColumnProps<T2>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool3 = ColumnPropGet.GetInstance.GetColumnProps<T3>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool4 = ColumnPropGet.GetInstance.GetColumnProps<T4>(MiscClass.MiscClass.ArrayActiveBool);
                            var propUpdateDate5 = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayUpdateDate);
                            var propActiveBool5 = ColumnPropGet.GetInstance.GetColumnProps<T5>(MiscClass.MiscClass.ArrayActiveBool);

                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);
                            context.Set<List<T5>>().Attach(listEntity5);

                            context.Entry(listEntity1).State = EntityState.Unchanged;
                            context.Entry(listEntity2).State = EntityState.Unchanged;
                            context.Entry(listEntity3).State = EntityState.Unchanged;
                            context.Entry(listEntity4).State = EntityState.Unchanged;
                            context.Entry(listEntity5).State = EntityState.Unchanged;

                            context.Entry(listEntity1).Property(propUpdateDate1.Name).IsModified = propUpdateDate1 != null ? true : false;
                            context.Entry(listEntity1).Property(propActiveBool1.Name).IsModified = propActiveBool1 != null ? true : false;
                            context.Entry(listEntity2).Property(propUpdateDate2.Name).IsModified = propUpdateDate2 != null ? true : false;
                            context.Entry(listEntity2).Property(propActiveBool2.Name).IsModified = propActiveBool2 != null ? true : false;
                            context.Entry(listEntity3).Property(propUpdateDate3.Name).IsModified = propUpdateDate3 != null ? true : false;
                            context.Entry(listEntity3).Property(propActiveBool3.Name).IsModified = propActiveBool3 != null ? true : false;
                            context.Entry(listEntity4).Property(propUpdateDate4.Name).IsModified = propUpdateDate4 != null ? true : false;
                            context.Entry(listEntity4).Property(propActiveBool4.Name).IsModified = propActiveBool4 != null ? true : false;
                            context.Entry(listEntity5).Property(propUpdateDate5.Name).IsModified = propUpdateDate5 != null ? true : false;
                            context.Entry(listEntity5).Property(propActiveBool5.Name).IsModified = propActiveBool5 != null ? true : false;


                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listEntity1, listIDIdentity2, listIDIdentity3, listIDIdentity4, listIDIdentity4,listIDIdentity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }

            return eFReturn;
        }

    }
}
