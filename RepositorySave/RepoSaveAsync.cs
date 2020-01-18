using EFHelper.Context;
using EFHelper.EntityPreparation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositorySave
{
    public  class RepoSaveAsync : InterfaceRepoSaveAsync
    {        

        public virtual async Task<T> SaveAsync<T>(T entity) where T : class
        {
            var entityResult = Activator.CreateInstance<T>();
            int hasil = 0;

            if (entity != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            
                            entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(entity);
                            context.Set<T>().Add(entity);
                            hasil =await context.SaveChangesAsync();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }
                }
            }

            entity = hasil > 0 ? entity : null;
            return entity;
        }

        public virtual async Task<bool> SaveAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0;
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var contextTrans = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (entity1 != null & entity2 != null)
                        {
                            
                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entity1);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entity2);
                            context.Set<T1>().Add(entity1);
                            context.Set<T2>().Add(entity2);
                            hasil = await context.SaveChangesAsync();
                        }
                        contextTrans.Commit();
                    }
                    catch { contextTrans.Rollback(); }
                }
            }
            return hasil > 0 ? true : false;
        }

        public virtual async Task<bool> SaveAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0;
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var contextTrans = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (entity1 != null & entity2 != null & entity3 != null)
                        {
                            
                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entity1);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entity2);
                            entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(entity3);
                            context.Set<T1>().Add(entity1);
                            context.Set<T2>().Add(entity2);
                            context.Set<T3>().Add(entity3);
                            hasil =await context.SaveChangesAsync();
                        }
                        contextTrans.Commit();
                    }
                    catch { contextTrans.Rollback(); }
                }
            }
            return hasil > 0 ? true : false;
        }

        public virtual async Task<bool> SaveAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0;
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var contextTrans = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (entity1 != null & entity2 != null & entity3 != null)
                        {
                            
                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entity1);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entity2);
                            entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(entity3);
                            entity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(entity4);
                            context.Set<T1>().Add(entity1);
                            context.Set<T2>().Add(entity2);
                            context.Set<T3>().Add(entity3);
                            context.Set<T4>().Add(entity4);
                            hasil = await context.SaveChangesAsync();
                        }
                        contextTrans.Commit();
                    }
                    catch { contextTrans.Rollback(); }
                }
            }
            return hasil > 0 ? true : false;
        }

        public virtual async Task<bool> SaveAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0;
            using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
            {
                using (var contextTrans = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (entity1 != null & entity2 != null & entity3 != null)
                        {
                            
                            entity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(entity1);
                            entity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(entity2);
                            entity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(entity3);
                            entity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(entity4);
                            entity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T5>(entity5);
                            context.Set<T1>().Add(entity1);
                            context.Set<T2>().Add(entity2);
                            context.Set<T3>().Add(entity3);
                            context.Set<T4>().Add(entity4);
                            context.Set<T5>().Add(entity5);

                            hasil =await context.SaveChangesAsync();
                        }
                        contextTrans.Commit();
                    }
                    catch { contextTrans.Rollback(); }
                }
            }
            return hasil > 0 ? true : false;
        }
    }
}
