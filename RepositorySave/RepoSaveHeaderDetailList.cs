using EFHelper.ColumnHelper;
using EFHelper.MiscClass;
using EFHelper.RepositoryDelete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.RepositorySave
{
    public  class RepoSaveHeaderDetailList : InterfaceRepoSaveHeaderDetailList
    {
        public virtual EFReturnValue<T> SaveHeaderDetail<T, T1>(T tblHeader, string idReferenceColName, List<T1> tblDetail1)
            where T : class
            where T1 : class
        {
            EFReturnValue<T> result = new EFReturnValue<T>();
            object objIDColumnHeader = null;
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & tblDetail1 != null)
            {
                RepoSave repoSave = new RepoSave();
                tblHeader = repoSave.Save<T>(tblHeader); // Safe first in main table
                result.Entity = tblHeader;
                RepoSaveList repoSaveList = new RepoSaveList();
                if (tblHeader != null)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        foreach (var item in tblDetail1)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T1>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }

                        var hasil = repoSaveList.SaveList<T1>(tblDetail1);//save to T1                      
                        if (hasil != null)
                        {
                            result.Result = true;
                        }
                        else
                        {
                            result.Result = false;
                            RepoDelete repoDelete = new RepoDelete();
                            repoDelete.Delete<T>(tblHeader);
                            // Hapus disini ya Headernya
                        }
                    }


                }

            }
            return result;
        }

        public virtual EFReturnValue<T> SaveHeaderDetail<T, T1, T2>(T tblHeader, string idReferenceColName, List<T1> tblDetail1, List<T2> tblDetail2)
            where T : class
            where T1 : class
            where T2 : class
        {
            EFReturnValue<T> result = new EFReturnValue<T>();
            object objIDColumnHeader = null;
            bool resultDetail = false;
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & tblDetail1 != null)
            {
                RepoSave repoSave = new RepoSave();
                RepoSaveList repoSaveList = new RepoSaveList();
                tblHeader = repoSave.Save<T>(tblHeader); // Safe first in main table
                result.Entity = tblHeader;
                if (tblHeader != null)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        foreach (var item in tblDetail1)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T1>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }
                        foreach (var item in tblDetail2)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T2>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }
                        resultDetail = repoSaveList.SaveList<T1, T2>(tblDetail1, tblDetail2);//save to T1                   
                        if (resultDetail)
                        {
                            result.Result = true;
                        }
                        else
                        {
                            result.Result = false;
                            // Hapus disini ya Headernya
                        }
                    }


                }

            }
            return result;
        }

        public virtual EFReturnValue<T> SaveHeaderDetail<T, T1, T2, T3>(T tblHeader, string idReferenceColName, List<T1> tblDetail1, List<T2> tblDetail2, List<T3> tblDetail3)
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
                RepoSave repoSave = new RepoSave();
                RepoSaveList repoSaveList = new RepoSaveList();
                tblHeader = repoSave.Save<T>(tblHeader); // Safe first in main table
                result.Entity = tblHeader;
                if (tblHeader != null)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        foreach (var item in tblDetail1)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T1>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }
                        foreach (var item in tblDetail2)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T2>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }
                        foreach (var item in tblDetail3)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T3>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }
                        resultDetail = repoSaveList.SaveList<T1, T2, T3>(tblDetail1, tblDetail2, tblDetail3);//save to T1                   
                        if (resultDetail)
                        {
                            result.Result = true;
                        }
                        else
                        {
                            result.Result = false;
                            // Hapus disini ya Headernya
                        }
                    }


                }

            }
            return result;
        }

        public virtual EFReturnValue<T> SaveHeaderDetail<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, List<T1> tblDetail1, List<T2> tblDetail2, List<T3> tblDetail3, List<T4> tblDetail4)
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
                RepoSave repoSave = new RepoSave();
                RepoSaveList repoSaveList = new RepoSaveList();
                tblHeader = repoSave.Save<T>(tblHeader); // Safe first in main table
                result.Entity = tblHeader;
                if (tblHeader != null)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        foreach (var item in tblDetail1)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T1>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }
                        foreach (var item in tblDetail2)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T2>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }
                        foreach (var item in tblDetail3)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T3>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }
                        foreach (var item in tblDetail4)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T4>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }
                        resultDetail = repoSaveList.SaveList<T1, T2, T3, T4>(tblDetail1, tblDetail2, tblDetail3, tblDetail4);//save to T1                   
                        if (resultDetail)
                        {
                            result.Result = true;
                        }
                        else
                        {
                            result.Result = false;
                            // Hapus disini ya Headernya
                        }
                    }


                }

            }
            return result;
        }

        public virtual EFReturnValue<T> SaveHeaderDetail<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, List<T1> tblDetail1, List<T2> tblDetail2, List<T3> tblDetail3, List<T4> tblDetail4, List<T5> tblDetail5)
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
                RepoSave repoSave = new RepoSave();
                RepoSaveList repoSaveList = new RepoSaveList();
                tblHeader = repoSave.Save<T>(tblHeader); // Safe first in main table
                result.Entity = tblHeader;
                if (tblHeader != null)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        foreach (var item in tblDetail1)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T1>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }
                        foreach (var item in tblDetail2)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T2>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }
                        foreach (var item in tblDetail3)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T3>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }
                        foreach (var item in tblDetail4)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T4>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }
                        foreach (var item in tblDetail5)
                        {
                            ColumnPropSet.GetInstance.SetColValue<T5>(item, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        }
                        resultDetail = repoSaveList.SaveList<T1, T2, T3, T4, T5>(tblDetail1, tblDetail2, tblDetail3, tblDetail4, tblDetail5);//save to T1                   
                        if (resultDetail)
                        {
                            result.Result = true;
                        }
                        else
                        {
                            result.Result = false;
                            // Hapus disini ya Headernya
                        }
                    }


                }

            }
            return result;
        }
    }   
}
