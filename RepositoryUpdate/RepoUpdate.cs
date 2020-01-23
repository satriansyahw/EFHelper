using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.MiscClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace EFHelper.RepositoryUpdate
{
    public class RepoUpdate : InterfaceRepoUpdate
    {
        EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        public EFReturnValue Update<T>(T entity) where T : class
        {
            int hasil = 0;
            if (entity != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {                            
                            var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T>(entity);//will update except activebool boolactive insertby insertbyid
                            entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T>(entity);
                            context.Set<T>().Attach(entity);
                            context.Entry(entity).State = EntityState.Unchanged;
                            foreach (PropertyInfo property in colNotNull)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity).Property(property.Name).IsModified = true;
                                }
                            }
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn; 
        }

        public EFReturnValue Update<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0;
            if (entity1 != null & entity2 !=null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            var colNotNull1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity1);//will update except activebool boolactive insertby insertbyid
                            var colNotNull2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity2);//will update except activebool boolactive insertby insertbyid

                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity1);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity2);

                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);

                            context.Entry(entity1).State = EntityState.Unchanged;
                            context.Entry(entity2).State = EntityState.Unchanged;

                            foreach (PropertyInfo property in colNotNull1)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity1).Property(property.Name).IsModified = true;
                                }
                            }
                            foreach (PropertyInfo property in colNotNull1)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity2).Property(property.Name).IsModified = true;
                                }
                            }
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1,entity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }

        public EFReturnValue Update<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0;
            if (entity1 != null & entity2 != null & entity3 !=null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            var colNotNull1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity1);//will update except activebool boolactive insertby insertbyid
                            var colNotNull2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity2);//will update except activebool boolactive insertby insertbyid
                            var colNotNull3 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity3);//will update except activebool boolactive insertby insertbyid

                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity1);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity2);
                            entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(entity3);

                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);

                            context.Entry(entity1).State = EntityState.Unchanged;
                            context.Entry(entity2).State = EntityState.Unchanged;
                            context.Entry(entity3).State = EntityState.Unchanged;

                            foreach (PropertyInfo property in colNotNull1)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity1).Property(property.Name).IsModified = true;
                                }
                            }
                            foreach (PropertyInfo property in colNotNull1)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity2).Property(property.Name).IsModified = true;
                                }
                            }
                            foreach (PropertyInfo property in colNotNull1)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity3).Property(property.Name).IsModified = true;
                                }
                            }
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1,entity2,entity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }

        public EFReturnValue Update<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0;
            if (entity1 != null & entity2 != null & entity3 != null & entity4 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            var colNotNull1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity1);//will update except activebool boolactive insertby insertbyid
                            var colNotNull2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity2);//will update except activebool boolactive insertby insertbyid
                            var colNotNull3 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity3);//will update except activebool boolactive insertby insertbyid
                            var colNotNull4 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T4>(entity4);//will update except activebool boolactive insertby insertbyid

                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity1);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity2);
                            entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(entity3);
                            entity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T4>(entity4);

                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);
                            context.Set<T4>().Attach(entity4);

                            context.Entry(entity1).State = EntityState.Unchanged;
                            context.Entry(entity2).State = EntityState.Unchanged;
                            context.Entry(entity3).State = EntityState.Unchanged;
                            context.Entry(entity4).State = EntityState.Unchanged;

                            foreach (PropertyInfo property in colNotNull1)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity1).Property(property.Name).IsModified = true;
                                }
                            }
                            foreach (PropertyInfo property in colNotNull1)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity2).Property(property.Name).IsModified = true;
                                }
                            }
                            foreach (PropertyInfo property in colNotNull1)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity3).Property(property.Name).IsModified = true;
                                }
                            }
                            foreach (PropertyInfo property in colNotNull1)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity4).Property(property.Name).IsModified = true;
                                }
                            }
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1,entity2,entity3,entity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }

        public EFReturnValue Update<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0;
            if (entity1 != null & entity2 != null & entity3 != null & entity4 != null & entity5 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            var colNotNull1 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity1);//will update except activebool boolactive insertby insertbyid
                            var colNotNull2 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity2);//will update except activebool boolactive insertby insertbyid
                            var colNotNull3 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity3);//will update except activebool boolactive insertby insertbyid
                            var colNotNull4 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T4>(entity4);//will update except activebool boolactive insertby insertbyid
                            var colNotNull5 = ColumnPropGet.GetInstance.GetPropertyColNotNull<T5>(entity5);//will update except activebool boolactive insertby insertbyid

                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity1);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity2);
                            entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(entity3);
                            entity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T4>(entity4);
                            entity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T5>(entity5);

                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);
                            context.Set<T4>().Attach(entity4);
                            context.Set<T5>().Attach(entity5);

                            context.Entry(entity1).State = EntityState.Unchanged;
                            context.Entry(entity2).State = EntityState.Unchanged;
                            context.Entry(entity3).State = EntityState.Unchanged;
                            context.Entry(entity4).State = EntityState.Unchanged;
                            context.Entry(entity5).State = EntityState.Unchanged;

                            foreach (PropertyInfo property in colNotNull1)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity1).Property(property.Name).IsModified = true;
                                }
                            }
                            foreach (PropertyInfo property in colNotNull1)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity2).Property(property.Name).IsModified = true;
                                }
                            }
                            foreach (PropertyInfo property in colNotNull1)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity3).Property(property.Name).IsModified = true;
                                }
                            }
                            foreach (PropertyInfo property in colNotNull1)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity4).Property(property.Name).IsModified = true;
                                }
                            }
                            foreach (PropertyInfo property in colNotNull1)
                            {
                                if (property != null)
                                {
                                    context.Entry(entity5).Property(property.Name).IsModified = true;
                                }
                            }
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity1,entity2,entity3,entity4,entity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
    }
}
