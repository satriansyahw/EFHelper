using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryUpdate
{
    public class RepoUpdateAllAsync : InterfaceRepoUpdateAllAsync
    {
        public virtual async Task<bool> UpdateAllAsync<T>(T entity) where T : class
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
                            context.Set<T>().Attach(entity);
                            context.Entry(entity).State = EntityState.Modified;
                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }
                }
            }
            return hasil > 0 ? true : false; 
        }

        public virtual async Task<bool> UpdateAllAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0;
            if (entity1 != null & entity2 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);

                            context.Entry(entity1).State = EntityState.Modified;
                            context.Entry(entity2).State = EntityState.Modified;

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }
                }
            }
            return hasil > 0 ? true : false;
        }

        public virtual async Task<bool> UpdateAllAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0;
            if (entity1 != null & entity2 != null & entity3 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);

                            context.Entry(entity1).State = EntityState.Modified;
                            context.Entry(entity2).State = EntityState.Modified;
                            context.Entry(entity3).State = EntityState.Modified;

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }
                }
            }
            return hasil > 0 ? true : false;
        }

        public virtual async Task<bool> UpdateAllAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
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
                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);
                            context.Set<T4>().Attach(entity4);

                            context.Entry(entity1).State = EntityState.Modified;
                            context.Entry(entity2).State = EntityState.Modified;
                            context.Entry(entity3).State = EntityState.Modified;
                            context.Entry(entity4).State = EntityState.Modified;

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }
                }
            }
            return hasil > 0 ? true : false;
        }

        public virtual async Task<bool> UpdateAllAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
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
                            context.Set<T1>().Attach(entity1);
                            context.Set<T2>().Attach(entity2);
                            context.Set<T3>().Attach(entity3);
                            context.Set<T4>().Attach(entity4);
                            context.Set<T5>().Attach(entity5);

                            context.Entry(entity1).State = EntityState.Modified;
                            context.Entry(entity2).State = EntityState.Modified;
                            context.Entry(entity3).State = EntityState.Modified;
                            context.Entry(entity4).State = EntityState.Modified;
                            context.Entry(entity5).State = EntityState.Modified;

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }
                }
            }
            return hasil > 0 ? true : false;
        }
    }
}
