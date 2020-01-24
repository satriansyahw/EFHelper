﻿using EFHelper.ColumnHelper;
using EFHelper.EntityPreparation;
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
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private static RepoSaveHeaderDetailAsync instance;
        public static RepoSaveHeaderDetailAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoSaveHeaderDetailAsync();
                return instance;
            }
        }
        public virtual async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1>(T tblHeader, string idReferenceColName, T1 tblDetail1)
            where T : class
            where T1 : class
        {
            
            object objIDColumnHeader = null;
            object objIDColumnDetail1 = null;
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & tblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(tblHeader);
                var saveMainTable = await repoSave.SaveAsync<T>(tblHeader); // Safe first in main table
                if (saveMainTable.IsSuccessConnection & saveMainTable.IsSuccessQuery)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        ColumnPropSet.GetInstance.SetColValue<T1>(tblDetail1, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        tblDetail1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(tblDetail1);
                        
                        var saveDetailTable = repoSave.SaveAsync<T1>(tblDetail1);//save to T1
                        var propIdColumnDetail1 = ColumnPropGet.GetInstance.GetIdentityColumnProps<T1>();
                        objIDColumnDetail1 = propIdColumnDetail1 != null ? propIdColumnDetail1.GetValue(tblDetail1) : null;
                        if (objIDColumnDetail1 != null)
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, tblDetail1);
                        }
                        else
                        {

                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader);
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ErrorMessage.SaveHeaderDetailFailed);
                        }
                    }


                }

            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2)
            where T : class
            where T1 : class where T2 : class
        {
            
            object objIDColumnHeader = null;
            bool resultDetail = false;
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & tblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(tblHeader);
                var saveMainTable = await repoSave.SaveAsync<T>(tblHeader); // Safe first in main table
                if (saveMainTable.IsSuccessConnection & saveMainTable.IsSuccessQuery)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        ColumnPropSet.GetInstance.SetColValue<T1>(tblDetail1, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T2>(tblDetail2, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails

                        tblDetail1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(tblDetail1);
                        tblDetail2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(tblDetail2);
                        
                        var saveDetailTable = await repoSave.SaveAsync<T1, T2>(tblDetail1, tblDetail2);//save to T1
                        if (resultDetail)
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, tblDetail1, tblDetail2);
                        }
                        else
                        {

                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader);
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ErrorMessage.SaveHeaderDetailFailed);
                        }
                    }


                }

            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2, T3>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            
            object objIDColumnHeader = null;
            bool resultDetail = false;
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & tblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(tblHeader);
                var saveMainTable = await repoSave.SaveAsync<T>(tblHeader); // Safe first in main table
                if (saveMainTable.IsSuccessConnection & saveMainTable.IsSuccessQuery)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        ColumnPropSet.GetInstance.SetColValue<T1>(tblDetail1, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T2>(tblDetail2, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T3>(tblDetail3, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails

                        tblDetail1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(tblDetail1);
                        tblDetail2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(tblDetail2);
                        tblDetail3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(tblDetail3);
                        
                        var saveDetailTable = await repoSave.SaveAsync<T1, T2, T3>(tblDetail1, tblDetail2, tblDetail3);//save to T1
                        if (resultDetail)
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, tblDetail1, tblDetail2, tblDetail3);
                        }
                        else
                        {
                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader);
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ErrorMessage.SaveHeaderDetailFailed);
                        }
                    }


                }

            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            
            object objIDColumnHeader = null;
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & tblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(tblHeader);
                var saveMainTable = await repoSave.SaveAsync<T>(tblHeader); // Safe first in main table
                if (saveMainTable.IsSuccessConnection & saveMainTable.IsSuccessQuery)
                {
                    var propIdColumnHeader = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
                    objIDColumnHeader = propIdColumnHeader != null ? propIdColumnHeader.GetValue(tblHeader) : null;
                    if (objIDColumnHeader != null)
                    {
                        ColumnPropSet.GetInstance.SetColValue<T1>(tblDetail1, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T2>(tblDetail2, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T3>(tblDetail3, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails
                        ColumnPropSet.GetInstance.SetColValue<T4>(tblDetail4, idReferenceColName, objIDColumnHeader); // set value ref id to tbldetails

                        tblDetail1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(tblDetail1);
                        tblDetail2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(tblDetail2);
                        tblDetail3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(tblDetail3);
                        tblDetail4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(tblDetail4);
                        
                        var saveDetailTable = await repoSave.SaveAsync<T1, T2, T3, T4>(tblDetail1, tblDetail2, tblDetail3, tblDetail4);//save to T1
                        if (saveDetailTable.IsSuccessConnection & saveDetailTable.IsSuccessQuery)
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, tblDetail1, tblDetail2, tblDetail3, tblDetail4);
                        }
                        else
                        {
                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader);
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ErrorMessage.SaveHeaderDetailFailed);

                        }
                    }


                }

            }
            return eFReturn;
        }
        public virtual async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4, T5 tblDetail5)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            
            object objIDColumnHeader = null;
            bool resultDetail = false;
            if (tblHeader != null & !string.IsNullOrEmpty(idReferenceColName) & tblDetail1 != null)
            {
                RepoSaveAsync repoSave = new RepoSaveAsync();
                tblHeader = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T>(tblHeader);
                var saveMainTable = await repoSave.SaveAsync<T>(tblHeader); // Safe first in main table
                if (saveMainTable.IsSuccessConnection & saveMainTable.IsSuccessQuery)
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

                        tblDetail1 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T1>(tblDetail1);
                        tblDetail2 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T2>(tblDetail2);
                        tblDetail3 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T3>(tblDetail3);
                        tblDetail4 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T4>(tblDetail4);
                        tblDetail5 = EntityPreparationBantuan.GetInstance.DictEntityPreparation["save"].SetPreparationEntity<T5>(tblDetail5);

                        var saveDetailTable = await repoSave.SaveAsync<T1, T2, T3, T4, T5>(tblDetail1, tblDetail2, tblDetail3, tblDetail4, tblDetail5);//save to T1
                        if (resultDetail)
                        {
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, true, 1, tblDetail1, tblDetail2, tblDetail3, tblDetail4, tblDetail5);
                        }
                        else
                        {
                            RepoDeleteAsync repoDelete = new RepoDeleteAsync();
                            await repoDelete.DeleteAsync<T>(tblHeader);
                            eFReturn = eFReturn.SetEFReturnValue(eFReturn, false, 0, ErrorMessage.SaveHeaderDetailFailed);
                        }
                    }


                }

            }
            return eFReturn;
        }
    }
}
