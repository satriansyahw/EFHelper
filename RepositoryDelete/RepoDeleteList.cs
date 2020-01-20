using EFHelper.ColumnHelper;
using EFHelper.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.RepositoryDelete
{
    public class RepoDeleteList : InterfaceRepoDeleteList
    {
        public virtual bool DeleteList<T>(List<T> listEntity) where T : class
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
                            context.Set<List<T>>().Attach(listEntity);
                            context.Set<List<T>>().Remove(listEntity);
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }
                }
            }

            return hasil > 0 ? true : false; 
        }

        public virtual bool DeleteList<T>(List<int> listIDIdentity) where T : class
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
                            context.Set<List<T>>().Attach(listEntity);
                            context.Set<List<T>>().Remove(listEntity);
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
