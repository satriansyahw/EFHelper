using EFHelper.Context;
using EFHelper.EntityPreparation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.RepositorySave
{
    public  class RepoSaveList : InterfaceRepoSaveList
    {
        public virtual IEnumerable<T> SaveList<T>(List<T> listEntity) where T : class
        {
            var entityResult = Activator.CreateInstance<T>();
            int hasil = 0;
            if (listEntity != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            
                            listEntity = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(listEntity);
                            foreach (var entity in listEntity)
                            {
                                context.Set<T>().Add(entity);
                            }
                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                        }
                        catch { contextTrans.Rollback(); }
                    }
                }
            }

            listEntity = hasil > 0 ? listEntity : null;
            return listEntity;
        }

        public virtual bool SaveList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            int hasil = 0;
            if (listEntity1 != null & listEntity2 !=null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(listEntity2);
                            foreach (var entity in listEntity1)
                            {
                                context.Set<T1>().Add(entity);
                            }
                            foreach (var entity in listEntity2)
                            {
                                context.Set<T2>().Add(entity);
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

        public virtual bool SaveList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
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
                            
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(listEntity3);

                            foreach (var entity in listEntity1)
                            {
                                context.Set<T1>().Add(entity);
                            }
                            foreach (var entity in listEntity2)
                            {
                                context.Set<T2>().Add(entity);
                            }
                            foreach (var entity in listEntity3)
                            {
                                context.Set<T3>().Add(entity);
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

        public virtual bool SaveList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
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
                            
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(listEntity4);
                            foreach (var entity in listEntity1)
                            {
                                context.Set<T1>().Add(entity);
                            }
                            foreach (var entity in listEntity2)
                            {
                                context.Set<T2>().Add(entity);
                            }
                            foreach (var entity in listEntity3)
                            {
                                context.Set<T3>().Add(entity);
                            }
                            foreach (var entity in listEntity4)
                            {
                                context.Set<T4>().Add(entity);
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

        public virtual bool SaveList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
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
                            
                            listEntity1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(listEntity1);
                            listEntity2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(listEntity2);
                            listEntity3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(listEntity3);
                            listEntity4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(listEntity4);
                            listEntity5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T5>(listEntity5);
                            foreach (var entity in listEntity1)
                            {
                                context.Set<T1>().Add(entity);
                            }
                            foreach (var entity in listEntity2)
                            {
                                context.Set<T2>().Add(entity);
                            }
                            foreach (var entity in listEntity3)
                            {
                                context.Set<T3>().Add(entity);
                            }
                            foreach (var entity in listEntity4)
                            {
                                context.Set<T4>().Add(entity);
                            }
                            foreach (var entity in listEntity5)
                            {
                                context.Set<T5>().Add(entity);
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
