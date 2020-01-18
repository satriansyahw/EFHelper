﻿using EFHelper.ColumnHelper;
using EFHelper.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryDelete
{
    public class RepoDeleteListAsync : InterfaceRepoDeleteListAsync
    {
        public virtual async Task<bool> DeleteListAsync<T>(List<T> listEntity) where T : class
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
                            foreach (var entity in listEntity)
                            {
                                context.Set<T>().Attach(entity);
                                context.Set<T>().Remove(entity);
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

        public virtual async Task<bool> DeleteListAsync<T>(List<int> listIDIdentity) where T : class
        {
            int hasil = 0;
            if (listIDIdentity.Count > 0 )
            {               
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            foreach (var IDIdentity in listIDIdentity)
                            {
                                T entity = Activator.CreateInstance<T>();
                                if (entity != null)
                                {
                                    ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                                    context.Set<T>().Attach(entity);
                                    context.Set<T>().Remove(entity);
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