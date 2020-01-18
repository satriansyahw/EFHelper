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
    public class RepoUpdateList : InterfaceRepoUpdateList
    {
        public bool UpdateList<T>(List<T> listEntity) where T : class
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
