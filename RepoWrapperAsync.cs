﻿using EFHelper.Context;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryDelete;
using EFHelper.RepositoryDeleteHeaderDetail;
using EFHelper.RepositoryDeleteSave;
using EFHelper.RepositoryList;
using EFHelper.RepositorySave;
using EFHelper.RepositorySaveUpdate;
using EFHelper.RepositorySaveUpdateDelete;
using EFHelper.RepositoryUpdate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper
{
    public class RepoWrapperAsync : DBContextBantuan,InterfaceRepoSaveAsync, InterfaceRepoSaveListAsync, InterfaceRepoSaveHeaderDetailAsync, InterfaceRepoSaveHeaderDetailListAsync, InterfaceRepoSaveUpdateAsync, InterfaceRepoSaveUpdateListAsync
        , InterfaceRepoUpdateAsync, InterfaceRepoUpdateListAsync, InterfaceRepoUpdateAllAsync, InterfaceRepoUpdateAllListAsync, InterfaceRepoDeleteAsync, InterfaceRepoDeleteListAsync, InterfaceRepoDeleteActiveBoolAsync, InterfaceRepoDeleteActiveBoolListAsync
        , InterfaceRepoDeleteHeaderDetailAsync, InterfaceRepoDeleteHeaderDetailListAsync, InterfaceRepoDeleteHeaderDetailActiveBoolAsync, InterfaceRepoDeleteHeaderDetailActiveBoolListAsync
        , InterfaceRepoListAsync, InterfaceRepoListQueryableAsync, InterfaceRepoDeleteSaveAsync, InterfaceRepoDeleteSaveListAsync, InterfaceRepoDeleteSaveActiveBoolAsync, InterfaceRepoDeleteSaveActiveBoolListAsync
        , InterfaceRepoSaveUpdateDeleteAsync, InterfaceRepoSaveUpdateDeleteListAsync, InterfaceRepoSaveUpdateDeleteActiveBoolAsync, InterfaceRepoSaveUpdateDeleteActiveBoolListAsync
    {
        private static RepoWrapperAsync instance;
        public new static RepoWrapperAsync GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoWrapperAsync();
                return instance;
            }
        }
        public RepoWrapperAsync()
        {

        }
        public RepoWrapperAsync(DbContext dbContext)
        {
            DBContextInfo.MyDbContext = dbContext;
        }
        public override void SetConnectionContext(DbContext dbContext)
        {
            this.SetConnectionContext(dbContext);
        }
        public override DbContext CreateConnectionContext()
        {
            return this.CreateConnectionContext();
        }
        public async Task<EFReturnValue> DeleteActiveBoolAsync<T>(T entity) where T : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync(entity);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync(entity1, entity2);
        }
       
        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync(entity1, entity2, entity3);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync(entity1, entity2, entity3, entity4);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync(entity1, entity2, entity3, entity4, entity5);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T>(int IDIdentity) where T : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync<T>(IDIdentity);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2>(int IDIdentity1, int IDIdentity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync<T1, T2>(IDIdentity1, IDIdentity2);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync<T1, T2, T3>(IDIdentity1, IDIdentity2, IDIdentity3);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync<T1, T2, T3, T4>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4);
        }

        public async Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteActiveBoolAsync.GetInstance.DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4, IDIdentity5);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T>(List<T> listEntity) where T : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync(listEntity);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync(listEntity1, listEntity2);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync(listEntity1, listEntity2, listEntity3);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T>(List<int> listIDIdentity) where T : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync<T>(listIDIdentity);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync<T1, T2>(listIDIdentity1, listIDIdentity2);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync<T1, T2, T3>(listIDIdentity1, listIDIdentity2, listIDIdentity3);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync<T1, T2, T3, T4>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4);
        }

        public async Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteActiveBoolListAsync.GetInstance.DeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4, listIDIdentity5);
        }

        public async Task<EFReturnValue> DeleteAsync<T>(int IDIdentity) where T : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync<T>(IDIdentity);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2>(int IDIdentity1, int IDIdentity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync<T1, T2>(IDIdentity1, IDIdentity2);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync<T1, T2, T3>(IDIdentity1, IDIdentity2, IDIdentity3);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync<T1, T2, T3, T4>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync<T1, T2, T3, T4, T5>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4, IDIdentity5);
        }

        public async Task<EFReturnValue> DeleteAsync<T>(T entity) where T : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync(entity);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync(entity1, entity2);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync(entity1, entity2, entity3);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync(entity1, entity2, entity3, entity4);
        }

        public async Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteAsync.GetInstance.DeleteAsync(entity1, entity2, entity3, entity4, entity5);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolAsync.GetInstance.DeleteHeaderDetailActiveBoolAsync<T, T1>(IDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolAsync.GetInstance.DeleteHeaderDetailActiveBoolAsync<T, T1, T2>(IDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolAsync.GetInstance.DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3>(IDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolAsync.GetInstance.DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4>(IDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolAsync.GetInstance.DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4, T5>(IDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolListAsync.GetInstance.DeleteHeaderDetailActiveBoolListAsync<T, T1>(listIDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolListAsync.GetInstance.DeleteHeaderDetailActiveBoolListAsync<T, T1, T2>(listIDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolListAsync.GetInstance.DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3>(listIDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolListAsync.GetInstance.DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4>(listIDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteHeaderDetailActiveBoolListAsync.GetInstance.DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4, T5>(listIDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return await RepoDeleteHeaderDetailAsync.GetInstance.DeleteHeaderDetailAsync<T, T1>(IDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteHeaderDetailAsync.GetInstance.DeleteHeaderDetailAsync<T, T1, T2>(IDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteHeaderDetailAsync.GetInstance.DeleteHeaderDetailAsync<T, T1, T2, T3>(IDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteHeaderDetailAsync.GetInstance.DeleteHeaderDetailAsync<T, T1, T2, T3, T4>(IDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteHeaderDetailAsync.GetInstance.DeleteHeaderDetailAsync<T, T1, T2, T3, T4, T5>(IDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return await RepoDeleteHeaderDetailListAsync.GetInstance.DeleteHeaderDetailListAsync<T, T1>(listIDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteHeaderDetailListAsync.GetInstance.DeleteHeaderDetailListAsync<T, T1, T2>(listIDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteHeaderDetailListAsync.GetInstance.DeleteHeaderDetailListAsync<T, T1, T2, T3>(listIDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteHeaderDetailListAsync.GetInstance.DeleteHeaderDetailListAsync<T, T1, T2, T3, T4>(listIDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteHeaderDetailListAsync.GetInstance.DeleteHeaderDetailListAsync<T, T1, T2, T3, T4, T5>(listIDIdentity, idReferenceColName);
        }

        public async Task<EFReturnValue> DeleteListAsync<T>(List<T> listEntity) where T : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync(listEntity);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync(listEntity1, listEntity2);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync(listEntity1, listEntity2, listEntity3);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public async Task<EFReturnValue> DeleteListAsync<T>(List<int> listIDIdentity) where T : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync<T>(listIDIdentity);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync<T1, T2>(listIDIdentity1, listIDIdentity2);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync<T1, T2, T3>(listIDIdentity1, listIDIdentity2, listIDIdentity3);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync<T1, T2, T3, T4>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4);
        }

        public async Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoDeleteListAsync.GetInstance.DeleteListAsync<T1, T2, T3, T4, T5>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4, listIDIdentity5);
        }

        public async Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList) where T : class
        {
            return await RepoListAsync.GetInstance.ListDataAsync<T>(searchFieldList);
        }

        public async Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class
        {
            return await RepoListAsync.GetInstance.ListDataAsync<T>(searchFieldList, sortColumn, isAscending, topTake);
        }

        public async Task<EFReturnValue> ListDataAsync<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class
            where TResult : class
        {
            return await RepoListAsync.GetInstance.ListDataAsync<TSource, TResult>(searchFieldList, sortColumn, isAscending, topTake);
        }
        public async Task<EFReturnValue> ListDataAsync<T>() where T : class
        {
            return await RepoListAsync.GetInstance.ListDataAsync<T>();
        }
        public async Task<EFReturnValue> SaveAsync<T>(T entity) where T : class
        {
            return await RepoSaveAsync.GetInstance.SaveAsync(entity);
        }

        public async Task<EFReturnValue> SaveAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return await RepoSaveAsync.GetInstance.SaveAsync(entity1, entity2);
        }

        public async Task<EFReturnValue> SaveAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveAsync.GetInstance.SaveAsync(entity1, entity2, entity3);
        }

        public async Task<EFReturnValue> SaveAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveAsync.GetInstance.SaveAsync(entity1, entity2, entity3, entity4);
        }

        public async Task<EFReturnValue> SaveAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveAsync.GetInstance.SaveAsync(entity1, entity2, entity3, entity4, entity5);
        }

        public async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1>(T tblHeader, string idReferenceColName, T1 tblDetail1)
            where T : class
            where T1 : class
        {
            return await RepoSaveHeaderDetailAsync.GetInstance.SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1);
        }

        public async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2)
            where T : class
            where T1 : class
            where T2 : class
        {
            return await RepoSaveHeaderDetailAsync.GetInstance.SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1, tblDetail2);
        }

        public async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2, T3>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveHeaderDetailAsync.GetInstance.SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3);
        }

        public async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveHeaderDetailAsync.GetInstance.SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3, tblDetail4);
        }

        public async Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4, T5 tblDetail5)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveHeaderDetailAsync.GetInstance.SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3, tblDetail4, tblDetail5);
        }

        public async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1)
            where T : class
            where T1 : class
        {
            return await RepoSaveHeaderDetailListAsync.GetInstance.SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1);
        }

        public async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2)
            where T : class
            where T1 : class
            where T2 : class
        {
            return await RepoSaveHeaderDetailListAsync.GetInstance.SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2);
        }

        public async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2, T3>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveHeaderDetailListAsync.GetInstance.SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3);
        }

        public async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3, List<T4> listTblDetail4)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveHeaderDetailListAsync.GetInstance.SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3, listTblDetail4);
        }

        public async Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3, List<T4> listTblDetail4, List<T5> listTblDetail5)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveHeaderDetailListAsync.GetInstance.SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3, listTblDetail4, listTblDetail5);
        }

        public async Task<EFReturnValue> SaveListAsync<T>(List<T> listEntity) where T : class
        {
            return await RepoSaveListAsync.GetInstance.SaveListAsync(listEntity);
        }

        public async Task<EFReturnValue> SaveListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return await RepoSaveListAsync.GetInstance.SaveListAsync(listEntity1, listEntity2);
        }

        public async Task<EFReturnValue> SaveListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveListAsync.GetInstance.SaveListAsync(listEntity1, listEntity2, listEntity3);
        }

        public async Task<EFReturnValue> SaveListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveListAsync.GetInstance.SaveListAsync(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public async Task<EFReturnValue> SaveListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveListAsync.GetInstance.SaveListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public async Task<EFReturnValue> SaveUpdateAsync<T1>(T1 entity1, bool isSaveT1) where T1 : class
        {
            return await RepoSaveUpdateAsync.GetInstance.SaveUpdateAsync(entity1, isSaveT1);
        }

        public async Task<EFReturnValue> SaveUpdateAsync<T1, T2>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2)
            where T1 : class
            where T2 : class
        {
            return await RepoSaveUpdateAsync.GetInstance.SaveUpdateAsync(entity1, isSaveT1, entity2, isSaveT2);
        }

        public async Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveUpdateAsync.GetInstance.SaveUpdateAsync(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3);
        }

        public async Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3, T4>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveUpdateAsync.GetInstance.SaveUpdateAsync(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4);
        }

        public async Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3, T4, T5>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4, T5 entity5, bool isSaveT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveUpdateAsync.GetInstance.SaveUpdateAsync(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4, entity5, isSaveT5);
        }

        public async Task<EFReturnValue> SaveUpdateListAsync<T1>(List<T1> listEntity1, bool isSaveT1) where T1 : class
        {
            return await RepoSaveUpdateListAsync.GetInstance.SaveUpdateListAsync(listEntity1, isSaveT1);
        }

        public async Task<EFReturnValue> SaveUpdateListAsync<T1, T2>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2)
            where T1 : class
            where T2 : class
        {
            return await RepoSaveUpdateListAsync.GetInstance.SaveUpdateListAsync(listEntity1, isSaveT1, listEntity2, isSaveT2);
        }

        public async Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoSaveUpdateListAsync.GetInstance.SaveUpdateListAsync(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3);
        }

        public async Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3, T4>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoSaveUpdateListAsync.GetInstance.SaveUpdateListAsync(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3, listEntity4, isSaveT4);
        }

        public async Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4, List<T5> listEntity5, bool isSaveT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoSaveUpdateListAsync.GetInstance.SaveUpdateListAsync(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3, listEntity4, isSaveT4, listEntity5, isSaveT5);
        }

        public async Task<EFReturnValue> UpdateAllAsync<T>(T entity) where T : class
        {
            return await RepoUpdateAllAsync.GetInstance.UpdateAllAsync(entity);
        }

        public async Task<EFReturnValue> UpdateAllAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return await RepoUpdateAllAsync.GetInstance.UpdateAllAsync(entity1, entity2);
        }

        public async Task<EFReturnValue> UpdateAllAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoUpdateAllAsync.GetInstance.UpdateAllAsync(entity1, entity2, entity3);
        }

        public async Task<EFReturnValue> UpdateAllAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoUpdateAllAsync.GetInstance.UpdateAllAsync(entity1, entity2, entity3, entity4);
        }

        public async Task<EFReturnValue> UpdateAllAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoUpdateAllAsync.GetInstance.UpdateAllAsync(entity1, entity2, entity3, entity4, entity5);
        }

        public async Task<EFReturnValue> UpdateAllListAsync<T>(List<T> listEntity) where T : class
        {
            return await RepoUpdateAllListAsync.GetInstance.UpdateAllListAsync(listEntity);
        }

        public async Task<EFReturnValue> UpdateAllListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return await RepoUpdateAllListAsync.GetInstance.UpdateAllListAsync(listEntity1, listEntity2);
        }

        public async Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoUpdateAllListAsync.GetInstance.UpdateAllListAsync(listEntity1, listEntity2, listEntity3);
        }

        public async Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoUpdateAllListAsync.GetInstance.UpdateAllListAsync(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public async Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoUpdateAllListAsync.GetInstance.UpdateAllListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public async Task<EFReturnValue> UpdateAsync<T>(T entity) where T : class
        {
            return await RepoUpdateAsync.GetInstance.UpdateAsync(entity);
        }

        public async Task<EFReturnValue> UpdateAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return await RepoUpdateAsync.GetInstance.UpdateAsync(entity1, entity2);
        }

        public async Task<EFReturnValue> UpdateAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoUpdateAsync.GetInstance.UpdateAsync(entity1, entity2, entity3);
        }

        public async Task<EFReturnValue> UpdateAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoUpdateAsync.GetInstance.UpdateAsync(entity1, entity2, entity3, entity4);
        }

        public async Task<EFReturnValue> UpdateAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoUpdateAsync.GetInstance.UpdateAsync(entity1, entity2, entity3, entity4, entity5);
        }

        public async Task<EFReturnValue> UpdateListAsync<T>(List<T> listlistEntity) where T : class
        {
            return await RepoUpdateListAsync.GetInstance.UpdateListAsync(listlistEntity);
        }

        public async Task<EFReturnValue> UpdateListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return await RepoUpdateListAsync.GetInstance.UpdateListAsync(listEntity1, listEntity2);
        }

        public async Task<EFReturnValue> UpdateListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return await RepoUpdateListAsync.GetInstance.UpdateListAsync(listEntity1, listEntity2, listEntity3);
        }

        public async Task<EFReturnValue> UpdateListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return await RepoUpdateListAsync.GetInstance.UpdateListAsync(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public async Task<EFReturnValue> UpdateListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return await RepoUpdateListAsync.GetInstance.UpdateListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public async Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable) where TResult : class
        {
            return await RepoListQueryableAsync.GetInstance.ListDataQueryableAsync(queryable);
        }

        public async Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable, List<SearchField> searchFieldList) where TResult : class
        {
            return await RepoListQueryableAsync.GetInstance.ListDataQueryableAsync(queryable, searchFieldList);
        }

        public async Task<EFReturnValue> ListDataQueryableAsync<TResult>(IQueryable<TResult> queryable, List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where TResult : class
        {
            return await RepoListQueryableAsync.GetInstance.ListDataQueryableAsync(queryable, searchFieldList, sortColumn, isAscending, topTake);
        }

        public Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1>(List<SearchField> deleteParameters, List<T1> listEntitySave1)
            where TDelete : class
            where T1 : class
        {
            return RepoDeleteSaveListAsync.GetInstance.DeleteSaveListAsync<TDelete, T1>(deleteParameters, listEntitySave1);
        }

        public Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2)
            where TDelete : class
            where T1 : class
            where T2 : class
        {
            return RepoDeleteSaveListAsync.GetInstance.DeleteSaveListAsync<TDelete, T1, T2>(deleteParameters, listEntitySave1, listEntitySave2);
        }

        public Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteSaveListAsync.GetInstance.DeleteSaveListAsync<TDelete, T1, T2, T3>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3);
        }

        public Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteSaveListAsync.GetInstance.DeleteSaveListAsync<TDelete, T1, T2, T3, T4>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4);
        }

        public Task<EFReturnValue> DeleteSaveListAsync<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4, List<T5> listEntitySave5)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteSaveListAsync.GetInstance.DeleteSaveListAsync<TDelete, T1, T2, T3, T4, T5>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4, listEntitySave5);
        }

        public Task<EFReturnValue> DeleteSaveAsync<TDelete, T1>(List<SearchField> deleteParameters, T1 entitySave1)
            where TDelete : class
            where T1 : class
        {
            return RepoDeleteSaveAsync.GetInstance.DeleteSaveAsync<TDelete, T1>(deleteParameters, entitySave1);
        }

        public Task<EFReturnValue> DeleteSaveAsync<TDelete, T1, T2>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2)
            where TDelete : class
            where T1 : class
            where T2 : class
        {
            return RepoDeleteSaveAsync.GetInstance.DeleteSaveAsync<TDelete, T1, T2>(deleteParameters, entitySave1, entitySave2);
        }

        public Task<EFReturnValue> DeleteSaveAsync<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteSaveAsync.GetInstance.DeleteSaveAsync<TDelete, T1, T2, T3>(deleteParameters, entitySave1, entitySave2, entitySave3);
        }

        public Task<EFReturnValue> DeleteSaveAsync<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteSaveAsync.GetInstance.DeleteSaveAsync<TDelete, T1, T2, T3, T4>(deleteParameters, entitySave1, entitySave2, entitySave3, entitySave4);
        }

        public Task<EFReturnValue> DeleteSaveAsync<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4, T5 entitySave5)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteSaveAsync.GetInstance.DeleteSaveAsync<TDelete, T1, T2, T3, T4, T5>(deleteParameters, entitySave1, entitySave2, entitySave3, entitySave4, entitySave5);
        }

        public Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1>(List<SearchField> deleteParameters, T1 entitySave1)
            where TDelete : class
            where T1 : class
        {
            return RepoDeleteSaveActiveBoolAsync.GetInstance.DeleteSaveActiveBoolAsync<TDelete, T1>(deleteParameters, entitySave1);
        }

        public Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2)
            where TDelete : class
            where T1 : class
            where T2 : class
        {
            return RepoDeleteSaveActiveBoolAsync.GetInstance.DeleteSaveActiveBoolAsync<TDelete, T1, T2>(deleteParameters, entitySave1, entitySave2);
        }

        public Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteSaveActiveBoolAsync.GetInstance.DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3>(deleteParameters, entitySave1, entitySave2, entitySave3);
        }

        public Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteSaveActiveBoolAsync.GetInstance.DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3, T4>(deleteParameters, entitySave1, entitySave2, entitySave3, entitySave4);
        }

        public Task<EFReturnValue> DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, T1 entitySave1, T2 entitySave2, T3 entitySave3, T4 entitySave4, T5 entitySave5)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteSaveActiveBoolAsync.GetInstance.DeleteSaveActiveBoolAsync<TDelete, T1, T2, T3, T4, T5>(deleteParameters, entitySave1, entitySave2, entitySave3, entitySave4, entitySave5);
        }

        public Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1>(List<SearchField> deleteParameters, List<T1> listEntitySave1)
            where TDelete : class
            where T1 : class
        {
            return RepoDeleteSaveActiveBoolListAsync.GetInstance.DeleteSaveActiveBoolListAsync<TDelete, T1>(deleteParameters, listEntitySave1);
        }

        public Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1, T2>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2)
            where TDelete : class
            where T1 : class
            where T2 : class
        {
            return RepoDeleteSaveActiveBoolListAsync.GetInstance.DeleteSaveActiveBoolListAsync<TDelete, T1, T2>(deleteParameters, listEntitySave1, listEntitySave2);
        }

        public Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoDeleteSaveActiveBoolListAsync.GetInstance.DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3);
        }

        public Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3, T4>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoDeleteSaveActiveBoolListAsync.GetInstance.DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3, T4>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4);
        }

        public Task<EFReturnValue> DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3, T4, T5>(List<SearchField> deleteParameters, List<T1> listEntitySave1, List<T2> listEntitySave2, List<T3> listEntitySave3, List<T4> listEntitySave4, List<T5> listEntitySave5)
            where TDelete : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoDeleteSaveActiveBoolListAsync.GetInstance.DeleteSaveActiveBoolListAsync<TDelete, T1, T2, T3, T4, T5>(deleteParameters, listEntitySave1, listEntitySave2, listEntitySave3, listEntitySave4, listEntitySave5);
        }

        public Task<EFReturnValue> SaveUpdateDeleteAsync<T1>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1) where T1 : class
        {
            return RepoSaveUpdateDeleteAsync.GetInstance.SaveUpdateDeleteAsync(entity1, enumSUDT1);
        }

        public Task<EFReturnValue> SaveUpdateDeleteAsync<T1, T2>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2)
            where T1 : class
            where T2 : class
        {
            return RepoSaveUpdateDeleteAsync.GetInstance.SaveUpdateDeleteAsync(entity1, enumSUDT1, entity2, enumSUDT2);
        }

        public Task<EFReturnValue> SaveUpdateDeleteAsync<T1, T2, T3>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoSaveUpdateDeleteAsync.GetInstance.SaveUpdateDeleteAsync(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3);
        }

        public Task<EFReturnValue> SaveUpdateDeleteAsync<T1, T2, T3, T4>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, T4 entity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoSaveUpdateDeleteAsync.GetInstance.SaveUpdateDeleteAsync(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4);
        }

        public Task<EFReturnValue> SaveUpdateDeleteAsync<T1, T2, T3, T4, T5>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, T4 entity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4, T5 entity5, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoSaveUpdateDeleteAsync.GetInstance.SaveUpdateDeleteAsync(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4, entity5, enumSUDT5);
        }

        public Task<EFReturnValue> SaveUpdateDeleteListAsync<T1>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1) where T1 : class
        {
            return RepoSaveUpdateDeleteListAsync.GetInstance.SaveUpdateDeleteListAsync(listEntity1, enumSUDT1);
        }

        public Task<EFReturnValue> SaveUpdateDeleteListAsync<T1, T2>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2)
            where T1 : class
            where T2 : class
        {
            return RepoSaveUpdateDeleteListAsync.GetInstance.SaveUpdateDeleteListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2);
        }

        public Task<EFReturnValue> SaveUpdateDeleteListAsync<T1, T2, T3>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoSaveUpdateDeleteListAsync.GetInstance.SaveUpdateDeleteListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3);
        }

        public Task<EFReturnValue> SaveUpdateDeleteListAsync<T1, T2, T3, T4>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoSaveUpdateDeleteListAsync.GetInstance.SaveUpdateDeleteListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3, listEntity4, enumSUDT4);
        }

        public Task<EFReturnValue> SaveUpdateDeleteListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4, List<T5> listEntity5, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoSaveUpdateDeleteListAsync.GetInstance.SaveUpdateDeleteListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3, listEntity4, enumSUDT4, listEntity5, enumSUDT5);
        }

        public Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1) where T1 : class
        {
            return RepoSaveUpdateDeleteActiveBoolAsync.GetInstance.SaveUpdateDeleteActiveBoolAsync(entity1, enumSUDT1);
        }

        public Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2)
            where T1 : class
            where T2 : class
        {
            return RepoSaveUpdateDeleteActiveBoolAsync.GetInstance.SaveUpdateDeleteActiveBoolAsync(entity1, enumSUDT1, entity2, enumSUDT2);
        }

        public Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2, T3>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoSaveUpdateDeleteActiveBoolAsync.GetInstance.SaveUpdateDeleteActiveBoolAsync(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3);
        }

        public Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2, T3, T4>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, T4 entity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoSaveUpdateDeleteActiveBoolAsync.GetInstance.SaveUpdateDeleteActiveBoolAsync(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4);
        }

        public Task<EFReturnValue> SaveUpdateDeleteActiveBoolAsync<T1, T2, T3, T4, T5>(T1 entity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, T2 entity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, T3 entity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, T4 entity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4, T5 entity5, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoSaveUpdateDeleteActiveBoolAsync.GetInstance.SaveUpdateDeleteActiveBoolAsync(entity1, enumSUDT1, entity2, enumSUDT2, entity3, enumSUDT3, entity4, enumSUDT4, entity5, enumSUDT5);
        }

        public Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1) where T1 : class
        {
            return RepoSaveUpdateDeleteActiveBoolListAsync.GetInstance.SaveUpdateDeleteActiveBoolListAsync(listEntity1, enumSUDT1);
        }

        public Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1, T2>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2)
            where T1 : class
            where T2 : class
        {
            return RepoSaveUpdateDeleteActiveBoolListAsync.GetInstance.SaveUpdateDeleteActiveBoolListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2);
        }

        public Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1, T2, T3>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return RepoSaveUpdateDeleteActiveBoolListAsync.GetInstance.SaveUpdateDeleteActiveBoolListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3);
        }

        public Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1, T2, T3, T4>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return RepoSaveUpdateDeleteActiveBoolListAsync.GetInstance.SaveUpdateDeleteActiveBoolListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3, listEntity4, enumSUDT4);
        }

        public Task<EFReturnValue> SaveUpdateDeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT1, List<T2> listEntity2, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT2, List<T3> listEntity3, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT3, List<T4> listEntity4, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT4, List<T5> listEntity5, MiscClass.MiscClass.EnumSaveUpdateDelete enumSUDT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return RepoSaveUpdateDeleteActiveBoolListAsync.GetInstance.SaveUpdateDeleteActiveBoolListAsync(listEntity1, enumSUDT1, listEntity2, enumSUDT2, listEntity3, enumSUDT3, listEntity4, enumSUDT4, listEntity5, enumSUDT5);
        }
    }
}