using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryList;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryDeleteHeaderDetail
{
    public class RepoDeleteHeaderDetailAsync : InterfaceDeleteHeaderDetailAsync
    {
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoDeleteHeaderDetailAsync instance;
        public static RepoDeleteHeaderDetailAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoDeleteHeaderDetailAsync();
                return instance;
            }
        }
        public virtual async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            int hasil = 0;
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = await this.getListData<T1>(IDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);

                            context.Set<T>().Remove(entity);
                            context.Set<List<T1>>().Remove(listEntity1);

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }        
        public virtual async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            int hasil = 0;
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = await this.getListData<T1>(IDIdentity, idReferenceColName);
                            List<T2> listEntity2 = await  this.getListData<T2>(IDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);

                            context.Set<T>().Remove(entity);
                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            int hasil = 0;
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = await this.getListData<T1>(IDIdentity, idReferenceColName);
                            List<T2> listEntity2 = await this.getListData<T2>(IDIdentity, idReferenceColName);
                            List<T3> listEntity3 = await this.getListData<T3>(IDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);

                            context.Set<T>().Remove(entity);
                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);
                            context.Set<List<T3>>().Remove(listEntity3);

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2, listEntity3);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            int hasil = 0;
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = await this.getListData<T1>(IDIdentity, idReferenceColName);
                            List<T2> listEntity2 = await this.getListData<T2>(IDIdentity, idReferenceColName);
                            List<T3> listEntity3 = await this.getListData<T3>(IDIdentity, idReferenceColName);
                            List<T4> listEntity4 = await this.getListData<T4>(IDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);

                            context.Set<T>().Remove(entity);
                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);
                            context.Set<List<T3>>().Remove(listEntity3);
                            context.Set<List<T4>>().Remove(listEntity4);

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity, listEntity1, listEntity2, listEntity3, listEntity4);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        public virtual async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            int hasil = 0;
            if (IDIdentity > 0 & !string.IsNullOrEmpty(idReferenceColName))
            {
                using (var context = DBContextBantuan.GetInstance.CreateConnectionContext())
                {
                    using (var contextTrans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            T entity = Activator.CreateInstance<T>();
                            ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                            List<T1> listEntity1 = await this.getListData<T1>(IDIdentity, idReferenceColName);
                            List<T2> listEntity2 = await this.getListData<T2>(IDIdentity, idReferenceColName);
                            List<T3> listEntity3 = await this.getListData<T3>(IDIdentity, idReferenceColName);
                            List<T4> listEntity4 = await this.getListData<T4>(IDIdentity, idReferenceColName);
                            List<T5> listEntity5 = await this.getListData<T5>(IDIdentity, idReferenceColName);

                            context.Set<T>().Attach(entity);
                            context.Set<List<T1>>().Attach(listEntity1);
                            context.Set<List<T2>>().Attach(listEntity2);
                            context.Set<List<T3>>().Attach(listEntity3);
                            context.Set<List<T4>>().Attach(listEntity4);
                            context.Set<List<T5>>().Attach(listEntity5);

                            context.Set<T>().Remove(entity);
                            context.Set<List<T1>>().Remove(listEntity1);
                            context.Set<List<T2>>().Remove(listEntity2);
                            context.Set<List<T3>>().Remove(listEntity3);
                            context.Set<List<T4>>().Remove(listEntity4);
                            context.Set<List<T5>>().Remove(listEntity5);

                            hasil = await context.SaveChangesAsync();
                            contextTrans.Commit();
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, hasil, entity,listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
                        }
                        catch (Exception ex) { eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, hasil, ex); contextTrans.Rollback(); }
                    }

                }
            }

            return eFReturn;
        }
        private async Task<List<T>> getListData<T>(int IDIdentity, string idReferenceColName) where T : class
        {
            List<SearchField> param = new System.Collections.Generic.List<SearchField>();
            param.Add(new SearchField { Name = idReferenceColName, Operator = "=", Value = IDIdentity.ToString() });
            RepoListAsync list = new RepoListAsync();
            var myList = await list.ListDataAsync<T>(param);
            return (myList.IsSuccessConnection & myList.IsSuccessQuery  & ((List<T>)myList.ReturnValue).Count > 0) ? (List<T>)myList.ReturnValue : null;
        }
    }
}
