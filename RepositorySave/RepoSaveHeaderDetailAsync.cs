using EFHelper.ColumnHelper;
using EFHelper.MiscClass;
using EFHelper.RepositoryDelete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositorySave
{
    public  class RepoSaveHeaderDetailAsync : InterfaceRepoSaveHeaderDetailAsync
    {
        public virtual async Task<EFReturnValue<T>> SaveHeaderDetail<T, T1>(T tblHeader, string idReferenceColName, T1 tblDetail1)
            where T : class
            where T1 : class
        {
            EFReturnValue<T> result = new EFReturnValue<T>();
            object objIDColumnHeader = null;
            object objIDColumnDetail1 = null;
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & tblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader=await repoSave.SaveAsync<T>(tblHeader); // Safe first in main table
                result.Entity = tblHeader;
                if (tblHeader != null)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        ColumnPropSet.GetInstance.SetColValue<T1>(tblDetail1, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        tblDetail1 =await repoSave.SaveAsync<T1>(tblDetail1);//save to T1
                        var propIdColumnDetail1 = ColumnPropGet.GetInstance.GetIdentityColumnProps<T1>();
                        objIDColumnDetail1 = propIdColumnDetail1 != null ? propIdColumnDetail1.GetValue(tblDetail1) : null;
                        if (objIDColumnDetail1 != null)
                        {
                            result.Result = true;
                        }
                        else
                        {
                            result.Result = false;
                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader);

                        }
                    }


                }

            }
            return result;
        }

        public virtual async Task<EFReturnValue<T>> SaveHeaderDetail<T, T1, T2>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2)
            where T : class
            where T1 : class where T2 : class
        {
            EFReturnValue<T> result = new EFReturnValue<T>();
            object objIDColumnHeader = null;
            bool  resultDetail =false;
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & tblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader = await repoSave.SaveAsync<T>(tblHeader); // Safe first in main table
                result.Entity = tblHeader;
                if (tblHeader != null)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        ColumnPropSet.GetInstance.SetColValue<T1>(tblDetail1, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T2>(tblDetail2, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        resultDetail = await repoSave.SaveAsync<T1,T2>(tblDetail1,tblDetail2);//save to T1
                        if (resultDetail)
                        {
                            result.Result = true;
                        }
                        else
                        {
                            result.Result = false;
                            // Hapus disini ya Headernya
                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader);
                        }
                    }


                }

            }
            return result;
        }

        public virtual async Task<EFReturnValue<T>> SaveHeaderDetail<T, T1, T2, T3>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            EFReturnValue<T> result = new EFReturnValue<T>();
            object objIDColumnHeader = null;
            bool resultDetail = false;
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & tblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader = await repoSave.SaveAsync<T>(tblHeader); // Safe first in main table
                result.Entity = tblHeader;
                if (tblHeader != null)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        ColumnPropSet.GetInstance.SetColValue<T1>(tblDetail1, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T2>(tblDetail2, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T3>(tblDetail3, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        resultDetail =await repoSave.SaveAsync<T1, T2,T3>(tblDetail1, tblDetail2,tblDetail3);//save to T1
                        if (resultDetail)
                        {
                            result.Result = true;
                        }
                        else
                        {
                            result.Result = false;
                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader);
                            // Hapus disini ya Headernya
                        }
                    }


                }

            }
            return result;
        }

        public virtual async Task<EFReturnValue<T>> SaveHeaderDetail<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            EFReturnValue<T> result = new EFReturnValue<T>();
            object objIDColumnHeader = null;
            bool resultDetail = false;
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & tblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader = await repoSave.SaveAsync<T>(tblHeader); // Safe first in main table
                result.Entity = tblHeader;
                if (tblHeader != null)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        ColumnPropSet.GetInstance.SetColValue<T1>(tblDetail1, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T2>(tblDetail2, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T3>(tblDetail3, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T4>(tblDetail4, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        resultDetail = await repoSave.SaveAsync<T1, T2, T3,T4>(tblDetail1, tblDetail2, tblDetail3,tblDetail4);//save to T1
                        if (resultDetail)
                        {
                            result.Result = true;
                        }
                        else
                        {
                            result.Result = false;
                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader);
                            // Hapus disini ya Headernya
                        }
                    }


                }

            }
            return result;
        }

        public virtual async Task<EFReturnValue<T>> SaveHeaderDetail<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4, T5 tblDetail5)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            EFReturnValue<T> result = new EFReturnValue<T>();
            object objIDColumnHeader = null;
            bool resultDetail = false;
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & tblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader = await repoSave.SaveAsync<T>(tblHeader); // Safe first in main table
                result.Entity = tblHeader;
                if (tblHeader != null)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        ColumnPropSet.GetInstance.SetColValue<T1>(tblDetail1, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T2>(tblDetail2, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T3>(tblDetail3, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T4>(tblDetail4, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T5>(tblDetail5, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        resultDetail = await repoSave.SaveAsync<T1, T2, T3, T4,T5>(tblDetail1, tblDetail2, tblDetail3, tblDetail4,tblDetail5);//save to T1
                        if (resultDetail)
                        {
                            result.Result = true;
                        }
                        else
                        {
                            result.Result = false;
                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader);
                            // Hapus disini ya Headernya
                        }
                    }


                }

            }
            return result;
        }
    }
}
