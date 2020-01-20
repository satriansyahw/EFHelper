using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.EntityPreparation;
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
        public virtual async Task<bool> DeleteActiveBoolListAsync<T>(List<T> listEntity) where T : class
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
                            TypeBantuan tipe = new TypeBantuan();
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate");
                            propUpdateDate = propUpdateDate != null ? propUpdateDate : ColumnPropGet.GetInstance.GetColumnProps<T>("updatetime");
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool");
                            propActiveBool = propActiveBool != null ? propActiveBool : ColumnPropGet.GetInstance.GetColumnProps<T>("boolactive");
                            context.Set<List<T>>().Attach(listEntity);
                            context.Entry(listEntity).State = EntityState.Unchanged;

                            if (propUpdateDate != null)
                            {
                                if (propUpdateDate != null)
                                {
                                    context.Entry(listEntity).Property(propUpdateDate.Name).IsModified = true;
                                }
                            }
                            if (propActiveBool != null)
                            {
                                if (propActiveBool != null)
                                {
                                    context.Entry(listEntity).Property(propActiveBool.Name).IsModified = true;
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

        public virtual async Task<bool> DeleteActiveBoolListAsync<T>(List<int> listIDIdentity) where T : class
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

                            List<T> listEntity = new List<T>();
                            foreach (var IDIdentity in listIDIdentity)
                            {
                                T entity = Activator.CreateInstance<T>();
                                if (entity != null)
                                {
                                    ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                                    listEntity.Add(entity);
                                }
                            }

                            listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(listEntity);
                            TypeBantuan tipe = new TypeBantuan();
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate");
                            propUpdateDate = propUpdateDate != null ? propUpdateDate : ColumnPropGet.GetInstance.GetColumnProps<T>("updatetime");
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool");
                            propActiveBool = propActiveBool != null ? propActiveBool : ColumnPropGet.GetInstance.GetColumnProps<T>("boolactive");
                            context.Set<List<T>>().Attach(listEntity);
                            context.Entry(listEntity).State = EntityState.Unchanged;
                            if (propUpdateDate != null)
                            {
                                if (propUpdateDate != null)
                                {
                                    context.Entry(listEntity).Property(propUpdateDate.Name).IsModified = true;
                                }
                            }
                            if (propActiveBool != null)
                            {
                                if (propActiveBool != null)
                                {
                                    context.Entry(listEntity).Property(propActiveBool.Name).IsModified = true;
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
