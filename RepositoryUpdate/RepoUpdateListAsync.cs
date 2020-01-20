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
    public class RepoUpdateListAsync : InterfaceRepoUpdateListAsync
    {
        public virtual async Task<bool> UpdateListAsync<T>(List<T> listEntity) where T : class
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
                            for (int i = 0; i < listEntity.Count; i++)
                            {
                                T entity = listEntity[i];
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
                            }                            
                           
                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }
                }
            }
            return hasil > 0 ? true : false; 
        }

        public virtual async Task<bool> UpdateListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0;
            if (listEntity1 != null & listEntity2 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            for (int i = 0; i < listEntity1.Count; i++)
                            {
                                T1 entity = listEntity1[i];
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity);//will update except activebool boolactive insertby insertbyid
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity);
                                context.Set<T1>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity2.Count; i++)
                            {
                                T2 entity = listEntity2[i];
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity);//will update except activebool boolactive insertby insertbyid
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity);
                                context.Set<T2>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }
                }
            }
            return hasil > 0 ? true : false;
        }

        public virtual async Task<bool> UpdateListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
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
                            for (int i = 0; i < listEntity1.Count; i++)
                            {
                                T1 entity = listEntity1[i];
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity);//will update except activebool boolactive insertby insertbyid
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity);
                                context.Set<T1>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity2.Count; i++)
                            {
                                T2 entity = listEntity2[i];
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity);//will update except activebool boolactive insertby insertbyid
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity);
                                context.Set<T2>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity3.Count; i++)
                            {
                                T3 entity = listEntity3[i];
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity);//will update except activebool boolactive insertby insertbyid
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(entity);
                                context.Set<T3>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }
                }
            }
            return hasil > 0 ? true : false;
        }

        public virtual async Task<bool> UpdateListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
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
                            for (int i = 0; i < listEntity1.Count; i++)
                            {
                                T1 entity = listEntity1[i];
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity);//will update except activebool boolactive insertby insertbyid
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity);
                                context.Set<T1>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity2.Count; i++)
                            {
                                T2 entity = listEntity2[i];
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity);//will update except activebool boolactive insertby insertbyid
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity);
                                context.Set<T2>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity3.Count; i++)
                            {
                                T3 entity = listEntity3[i];
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity);//will update except activebool boolactive insertby insertbyid
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(entity);
                                context.Set<T3>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity4.Count; i++)
                            {
                                T4 entity = listEntity4[i];
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T4>(entity);//will update except activebool boolactive insertby insertbyid
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T4>(entity);
                                context.Set<T4>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }
                }
            }
            return hasil > 0 ? true : false;
        }

        public virtual async Task<bool> UpdateListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
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
                            for (int i = 0; i < listEntity1.Count; i++)
                            {
                                T1 entity = listEntity1[i];
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T1>(entity);//will update except activebool boolactive insertby insertbyid
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T1>(entity);
                                context.Set<T1>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity2.Count; i++)
                            {
                                T2 entity = listEntity2[i];
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T2>(entity);//will update except activebool boolactive insertby insertbyid
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T2>(entity);
                                context.Set<T2>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity3.Count; i++)
                            {
                                T3 entity = listEntity3[i];
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T3>(entity);//will update except activebool boolactive insertby insertbyid
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T3>(entity);
                                context.Set<T3>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity4.Count; i++)
                            {
                                T4 entity = listEntity4[i];
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T4>(entity);//will update except activebool boolactive insertby insertbyid
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T4>(entity);
                                context.Set<T4>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
                            for (int i = 0; i < listEntity5.Count; i++)
                            {
                                T5 entity = listEntity5[i];
                                var colNotNull = ColumnPropGet.GetInstance.GetPropertyColNotNull<T5>(entity);//will update except activebool boolactive insertby insertbyid
                                entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["updatedefined"].SetPreparationEntity<T5>(entity);
                                context.Set<T5>().Attach(entity);
                                context.Entry(entity).State = EntityState.Unchanged;
                                foreach (PropertyInfo property in colNotNull)
                                {
                                    if (property != null)
                                    {
                                        context.Entry(entity).Property(property.Name).IsModified = true;
                                    }

                                }
                            }
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
