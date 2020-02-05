using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryList;

namespace EFHelper.RepositoryDeleteSave
{
    public class RepoDeleteSaveList : InterfaceRepoDeleteSaveList
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoDeleteSaveList instance;
        public static RepoDeleteSaveList GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoDeleteSaveList();
                return instance;
            }
        }
        public virtual EFReturnValue DeleteSaveList<TDelete, T1>(List<SearchField> deleteParameters, List<T1> listEntitySave1)
            where TDelete : class
            where T1 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntitySave1 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<TDelete> listDelete = new List<TDelete>();
                            var listDeleteRV = RepoList.GetInstance.ListData<TDelete>(deleteParameters);
                            if (listDeleteRV.IsSuccessConnection & listDeleteRV.IsSuccessQuery)
                            {
                                listDelete = (List<TDelete>)listDeleteRV.ReturnValue;
                            }
                            //for delete will be delete physicallay

                            listEntitySave1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(listEntitySave1);
                            
                            context.Set<List<T1>>().Add(listEntitySave1);
                            context.Set<List<TDelete>>().Attach(listDelete);
                            context.Set<List<TDelete>>().Remove(listDelete);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listDelete, listEntitySave1);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteSaveList<TDelete, T1, T2>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2)
            where TDelete : class
            where T1 : class
            where T2 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntitySave1 != null & listEntitySave2 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<TDelete> listDelete = new List<TDelete>();
                            var listDeleteRV = RepoList.GetInstance.ListData<TDelete>(deleteParameters);
                            if (listDeleteRV.IsSuccessConnection & listDeleteRV.IsSuccessQuery)
                            {
                                listDelete = (List<TDelete>)listDeleteRV.ReturnValue;
                            }
                            //for delete will be delete physicallay

                            listEntitySave1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(listEntitySave1);
                            listEntitySave2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(listEntitySave2);
 
                            context.Set<List<T1>>().Add(listEntitySave1);
                            context.Set<List<T2>>().Add(listEntitySave2);
                            context.Set<List<TDelete>>().Attach(listDelete);
                            context.Set<List<TDelete>>().Remove(listDelete);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listDelete, listEntitySave1, listEntitySave2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteSaveList<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntitySave1 != null & listEntitySave2 != null & listEntitySave3 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<TDelete> listDelete = new List<TDelete>();
                            var listDeleteRV = RepoList.GetInstance.ListData<TDelete>(deleteParameters);
                            if (listDeleteRV.IsSuccessConnection & listDeleteRV.IsSuccessQuery)
                            {
                                listDelete = (List<TDelete>)listDeleteRV.ReturnValue;
                            }
                            //for delete will be delete physicallay

                            listEntitySave1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(listEntitySave1);
                            listEntitySave2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(listEntitySave2);
                            listEntitySave3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(listEntitySave3);
                            
                            context.Set<List<T1>>().Add(listEntitySave1);
                            context.Set<List<T2>>().Add(listEntitySave2);
                            context.Set<List<T3>>().Add(listEntitySave3);
                            context.Set<List<TDelete>>().Attach(listDelete);
                            context.Set<List<TDelete>>().Remove(listDelete);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listDelete, listEntitySave1, listEntitySave2, listEntitySave3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteSaveList<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntitySave1 != null & listEntitySave2 != null & listEntitySave3 != null & listEntitySave4 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<TDelete> listDelete = new List<TDelete>();
                            var listDeleteRV = RepoList.GetInstance.ListData<TDelete>(deleteParameters);
                            if (listDeleteRV.IsSuccessConnection & listDeleteRV.IsSuccessQuery)
                            {
                                listDelete = (List<TDelete>)listDeleteRV.ReturnValue;
                            }
                            //for delete will be delete physicallay

                            listEntitySave1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(listEntitySave1);
                            listEntitySave2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(listEntitySave2);
                            listEntitySave3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(listEntitySave3);
                            listEntitySave4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(listEntitySave4);
                            
                            context.Set<List<T1>>().Add(listEntitySave1);
                            context.Set<List<T2>>().Add(listEntitySave2);
                            context.Set<List<T3>>().Add(listEntitySave3);
                            context.Set<List<T4>>().Add(listEntitySave4);
                            context.Set<List<TDelete>>().Attach(listDelete);
                            context.Set<List<TDelete>>().Remove(listDelete);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listDelete, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual EFReturnValue DeleteSaveList<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4, List<T5> listEntitySave5)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0; eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
            if (listEntitySave1 != null & listEntitySave2 != null & listEntitySave3 != null & listEntitySave4 != null & listEntitySave5 != null)
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            List<TDelete> listDelete = new List<TDelete>();
                            var listDeleteRV = RepoList.GetInstance.ListData<TDelete>(deleteParameters);
                            if (listDeleteRV.IsSuccessConnection & listDeleteRV.IsSuccessQuery)
                            {
                                listDelete = (List<TDelete>)listDeleteRV.ReturnValue;
                            }
                            //for delete will be delete physicallay

                            listEntitySave1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(listEntitySave1);
                            listEntitySave2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(listEntitySave2);
                            listEntitySave3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(listEntitySave3);
                            listEntitySave4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(listEntitySave4);
                            listEntitySave5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T5>(listEntitySave5);

                            context.Set<List<T1>>().Add(listEntitySave1);
                            context.Set<List<T2>>().Add(listEntitySave2);
                            context.Set<List<T3>>().Add(listEntitySave3);
                            context.Set<List<T4>>().Add(listEntitySave4);
                            context.Set<List<T5>>().Add(listEntitySave5);
                            context.Set<List<TDelete>>().Attach(listDelete);
                            context.Set<List<TDelete>>().Remove(listDelete);

                            hasil = context.SaveChanges();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listDelete, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4, listEntitySave5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
    }
}
