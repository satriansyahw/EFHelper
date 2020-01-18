using EFHelper.ColumnHelper;
using EFHelper.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.RepositoryDelete
{
    public class RepoDelete : InterfaceRepoDelete
    {
        public virtual bool Delete<T>(T entity) where T : class
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
                            context.Set<T>().Remove(entity);
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }
                }
            }

            return hasil > 0 ? true : false; 
        }

        public virtual bool Delete<T>(int IDIdentity) where T : class
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
                            context.Set<T>().Attach(entity);
                            context.Set<T>().Remove(entity);
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
