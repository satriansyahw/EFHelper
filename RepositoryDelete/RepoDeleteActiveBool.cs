using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.TypeHelper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EFHelper.RepositoryDelete
{
    public class RepoDeleteActiveBool : InterfaceRepoDeleteActiveBool
    {
        public virtual bool DeleteActiveBool<T>(T entity) where T : class
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
                            entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(entity);
                            TypeBantuan tipe = new TypeBantuan();
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate");
                            propUpdateDate = propUpdateDate != null ? propUpdateDate : ColumnPropGet.GetInstance.GetColumnProps<T>("updatetime");
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool");
                            propActiveBool = propActiveBool != null ? propActiveBool : ColumnPropGet.GetInstance.GetColumnProps<T>("boolactive");
                            context.Set<T>().Attach(entity);
                            context.Entry(entity).State = EntityState.Unchanged;

                            if (propUpdateDate != null)
                            {
                                if (propUpdateDate != null)
                                {
                                    context.Entry(entity).Property(propUpdateDate.Name).IsModified = true;
                                }
                            }
                            if (propActiveBool != null)
                            {
                                if (propActiveBool != null)
                                {
                                    context.Entry(entity).Property(propActiveBool.Name).IsModified = true;
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

        public virtual bool DeleteActiveBool<T>(int IDIdentity) where T : class
        {
            int hasil = 0;
            T entity = Activator.CreateInstance<T>();
            if (IDIdentity > 0 & entity != null)
            {
               
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);

                            entity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["delete"].SetPreparationEntity<T>(entity);
                            TypeBantuan tipe = new TypeBantuan();
                            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate");
                            propUpdateDate = propUpdateDate != null ? propUpdateDate : ColumnPropGet.GetInstance.GetColumnProps<T>("updatetime");
                            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool");
                            propActiveBool = propActiveBool != null ? propActiveBool : ColumnPropGet.GetInstance.GetColumnProps<T>("boolactive");
                            context.Set<T>().Attach(entity);
                            context.Entry(entity).State = EntityState.Unchanged;
                            if (propUpdateDate != null)
                            {
                                if (propUpdateDate != null)
                                {
                                    context.Entry(entity).Property(propUpdateDate.Name).IsModified = true;
                                }
                            }
                            if (propActiveBool != null)
                            {
                                if (propActiveBool != null)
                                {
                                    context.Entry(entity).Property(propActiveBool.Name).IsModified = true;
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
