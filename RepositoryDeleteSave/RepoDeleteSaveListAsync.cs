using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EFHelper.Context;
using EFHelper.EntityPreparation;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryList;

namespace EFHelper.RepositoryDeleteSave
{
    public class RepoDeleteSaveListAsync : InterfaceRepoDeleteSaveListAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoDeleteSaveListAsync instance;
        public static RepoDeleteSaveListAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoDeleteSaveListAsync();
                return instance;
            }
        }
        public virtual async Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1>(List<SearchField> deleteParameters, List<T1> listEntitySave1)
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

                            foreach (var item in listDelete) { context.Set<TDelete>().Attach(item); context.Set<TDelete>().Remove(item); }
                            foreach (var item in listEntitySave1) { context.Set<T1>().Add(item); }

                            await Task.Run(()=> {hasil = context.SaveChanges();});
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listDelete, listEntitySave1);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2)
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

                            foreach (var item in listDelete) { context.Set<TDelete>().Attach(item); context.Set<TDelete>().Remove(item); }
                            foreach (var item in listEntitySave1) { context.Set<T1>().Add(item); }
                            foreach (var item in listEntitySave2) { context.Set<T2>().Add(item); }


                            await Task.Run(()=> {hasil = context.SaveChanges();});
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listDelete, listEntitySave1, listEntitySave2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3)
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

                            foreach (var item in listDelete) { context.Set<TDelete>().Attach(item); context.Set<TDelete>().Remove(item); }
                            foreach (var item in listEntitySave1) { context.Set<T1>().Add(item); }
                            foreach (var item in listEntitySave2) { context.Set<T2>().Add(item); }
                            foreach (var item in listEntitySave3) { context.Set<T3>().Add(item); }


                            await Task.Run(()=> {hasil = context.SaveChanges();});
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listDelete, listEntitySave1, listEntitySave2, listEntitySave3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4)
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

                            foreach (var item in listDelete) { context.Set<TDelete>().Attach(item); context.Set<TDelete>().Remove(item); }
                            foreach (var item in listEntitySave1) { context.Set<T1>().Add(item); }
                            foreach (var item in listEntitySave2) { context.Set<T2>().Add(item); }
                            foreach (var item in listEntitySave3) { context.Set<T3>().Add(item); }
                            foreach (var item in listEntitySave4) { context.Set<T4>().Add(item); }


                            await Task.Run(()=> {hasil = context.SaveChanges();});
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, listDelete, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ex.Message); contextTrans.Rollback(); }
                    }
                }
            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4, List<T5> listEntitySave5)
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

                            foreach (var item in listDelete) { context.Set<TDelete>().Attach(item); context.Set<TDelete>().Remove(item); }
                            foreach (var item in listEntitySave1) { context.Set<T1>().Add(item); }
                            foreach (var item in listEntitySave2) { context.Set<T2>().Add(item); }
                            foreach (var item in listEntitySave3) { context.Set<T3>().Add(item); }
                            foreach (var item in listEntitySave4) { context.Set<T4>().Add(item); }
                            foreach (var item in listEntitySave5) { context.Set<T5>().Add(item); }


                            await Task.Run(()=> {hasil = context.SaveChanges();});
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
