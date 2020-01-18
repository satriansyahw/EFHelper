using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EFHelper.RepositoryUpdate
{
    public class RepoUpdateAll : InterfaceRepoUpdateAll
    {
        public bool UpdateAll<T>(T entity) where T : class
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
                            hasil = context.SaveChanges();
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
