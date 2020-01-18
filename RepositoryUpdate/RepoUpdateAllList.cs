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
    public class RepoUpdateAllList : InterfaceRepoUpdateAllList
    {
        public bool UpdateAllList<T>(List<T> listEntity) where T : class
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
                                context.Set<T>().Attach(entity);
                                context.Entry(entity).State = EntityState.Modified;
                            }
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
