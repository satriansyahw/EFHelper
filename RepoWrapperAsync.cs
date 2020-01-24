using EFHelper.Context;
using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.RepositoryDelete;
using EFHelper.RepositoryDeleteHeaderDetail;
using EFHelper.RepositoryList;
using EFHelper.RepositorySave;
using EFHelper.RepositorySaveUpdate;
using EFHelper.RepositoryUpdate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper
{
    public class RepoWrapperAsync : DBContextBantuan,InterfaceRepoSaveAsync, InterfaceRepoSaveListAsync, InterfaceRepoSaveHeaderDetailAsync, InterfaceRepoSaveHeaderDetailListAsync, InterfaceSaveUpdateAsync, InterfaceSaveUpdateListAsync
        , InterfaceRepoUpdateAsync, InterfaceRepoUpdateListAsync, InterfaceRepoUpdateAllAsync, InterfaceRepoUpdateAllListAsync, InterfaceRepoDeleteAsync, InterfaceRepoDeleteListAsync, InterfaceRepoDeleteActiveBoolAsync, InterfaceRepoDeleteActiveBoolListAsync
        , InterfaceDeleteHeaderDetailAsync, InterfaceDeleteHeaderDetailListAsync, InterfaceDeleteHeaderDetailActiveBoolAsync, InterfaceDeleteHeaderDetailActiveBoolListAsync
        , InterfaceRepoListAsync
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
        public Task<EFReturnValue> DeleteActiveBoolAsync<T>(T entity) where T : class
        {
            return ((InterfaceRepoDeleteActiveBoolAsync)GetInstance).DeleteActiveBoolAsync(entity);
        }

        public Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDeleteActiveBoolAsync)GetInstance).DeleteActiveBoolAsync(entity1, entity2);
        }
       
        public Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDeleteActiveBoolAsync)GetInstance).DeleteActiveBoolAsync(entity1, entity2, entity3);
        }

        public Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDeleteActiveBoolAsync)GetInstance).DeleteActiveBoolAsync(entity1, entity2, entity3, entity4);
        }

        public Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDeleteActiveBoolAsync)GetInstance).DeleteActiveBoolAsync(entity1, entity2, entity3, entity4, entity5);
        }

        public Task<EFReturnValue> DeleteActiveBoolAsync<T>(int IDIdentity) where T : class
        {
            return ((InterfaceRepoDeleteActiveBoolAsync)GetInstance).DeleteActiveBoolAsync<T>(IDIdentity);
        }

        public Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2>(int IDIdentity1, int IDIdentity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDeleteActiveBoolAsync)GetInstance).DeleteActiveBoolAsync<T1, T2>(IDIdentity1, IDIdentity2);
        }

        public Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDeleteActiveBoolAsync)GetInstance).DeleteActiveBoolAsync<T1, T2, T3>(IDIdentity1, IDIdentity2, IDIdentity3);
        }

        public Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDeleteActiveBoolAsync)GetInstance).DeleteActiveBoolAsync<T1, T2, T3, T4>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4);
        }

        public Task<EFReturnValue> DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDeleteActiveBoolAsync)GetInstance).DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4, IDIdentity5);
        }

        public Task<EFReturnValue> DeleteActiveBoolListAsync<T>(List<T> listEntity) where T : class
        {
            return ((InterfaceRepoDeleteActiveBoolListAsync)GetInstance).DeleteActiveBoolListAsync(listEntity);
        }

        public Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDeleteActiveBoolListAsync)GetInstance).DeleteActiveBoolListAsync(listEntity1, listEntity2);
        }

        public Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDeleteActiveBoolListAsync)GetInstance).DeleteActiveBoolListAsync(listEntity1, listEntity2, listEntity3);
        }

        public Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDeleteActiveBoolListAsync)GetInstance).DeleteActiveBoolListAsync(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDeleteActiveBoolListAsync)GetInstance).DeleteActiveBoolListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public Task<EFReturnValue> DeleteActiveBoolListAsync<T>(List<int> listIDIdentity) where T : class
        {
            return ((InterfaceRepoDeleteActiveBoolListAsync)GetInstance).DeleteActiveBoolListAsync<T>(listIDIdentity);
        }

        public Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDeleteActiveBoolListAsync)GetInstance).DeleteActiveBoolListAsync<T1, T2>(listIDIdentity1, listIDIdentity2);
        }

        public Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDeleteActiveBoolListAsync)GetInstance).DeleteActiveBoolListAsync<T1, T2, T3>(listIDIdentity1, listIDIdentity2, listIDIdentity3);
        }

        public Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDeleteActiveBoolListAsync)GetInstance).DeleteActiveBoolListAsync<T1, T2, T3, T4>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4);
        }

        public Task<EFReturnValue> DeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDeleteActiveBoolListAsync)GetInstance).DeleteActiveBoolListAsync<T1, T2, T3, T4, T5>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4, listIDIdentity5);
        }

        public Task<EFReturnValue> DeleteAsync<T>(int IDIdentity) where T : class
        {
            return ((InterfaceRepoDeleteAsync)GetInstance).DeleteAsync<T>(IDIdentity);
        }

        public Task<EFReturnValue> DeleteAsync<T1, T2>(int IDIdentity1, int IDIdentity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDeleteAsync)GetInstance).DeleteAsync<T1, T2>(IDIdentity1, IDIdentity2);
        }

        public Task<EFReturnValue> DeleteAsync<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDeleteAsync)GetInstance).DeleteAsync<T1, T2, T3>(IDIdentity1, IDIdentity2, IDIdentity3);
        }

        public Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDeleteAsync)GetInstance).DeleteAsync<T1, T2, T3, T4>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4);
        }

        public Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDeleteAsync)GetInstance).DeleteAsync<T1, T2, T3, T4, T5>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4, IDIdentity5);
        }

        public Task<EFReturnValue> DeleteAsync<T>(T entity) where T : class
        {
            return ((InterfaceRepoDeleteAsync)GetInstance).DeleteAsync(entity);
        }

        public Task<EFReturnValue> DeleteAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDeleteAsync)GetInstance).DeleteAsync(entity1, entity2);
        }

        public Task<EFReturnValue> DeleteAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDeleteAsync)GetInstance).DeleteAsync(entity1, entity2, entity3);
        }

        public Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDeleteAsync)GetInstance).DeleteAsync(entity1, entity2, entity3, entity4);
        }

        public Task<EFReturnValue> DeleteAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDeleteAsync)GetInstance).DeleteAsync(entity1, entity2, entity3, entity4, entity5);
        }

        public Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolAsync)GetInstance).DeleteHeaderDetailActiveBoolAsync<T, T1>(IDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolAsync)GetInstance).DeleteHeaderDetailActiveBoolAsync<T, T1, T2>(IDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolAsync)GetInstance).DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3>(IDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolAsync)GetInstance).DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4>(IDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolAsync)GetInstance).DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4, T5>(IDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolListAsync)GetInstance).DeleteHeaderDetailActiveBoolListAsync<T, T1>(listIDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolListAsync)GetInstance).DeleteHeaderDetailActiveBoolListAsync<T, T1, T2>(listIDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolListAsync)GetInstance).DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3>(listIDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolListAsync)GetInstance).DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4>(listIDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolListAsync)GetInstance).DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4, T5>(listIDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return ((InterfaceDeleteHeaderDetailAsync)GetInstance).DeleteHeaderDetailAsync<T, T1>(IDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return ((InterfaceDeleteHeaderDetailAsync)GetInstance).DeleteHeaderDetailAsync<T, T1, T2>(IDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceDeleteHeaderDetailAsync)GetInstance).DeleteHeaderDetailAsync<T, T1, T2, T3>(IDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceDeleteHeaderDetailAsync)GetInstance).DeleteHeaderDetailAsync<T, T1, T2, T3, T4>(IDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailAsync<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceDeleteHeaderDetailAsync)GetInstance).DeleteHeaderDetailAsync<T, T1, T2, T3, T4, T5>(IDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return ((InterfaceDeleteHeaderDetailListAsync)GetInstance).DeleteHeaderDetailListAsync<T, T1>(listIDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return ((InterfaceDeleteHeaderDetailListAsync)GetInstance).DeleteHeaderDetailListAsync<T, T1, T2>(listIDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceDeleteHeaderDetailListAsync)GetInstance).DeleteHeaderDetailListAsync<T, T1, T2, T3>(listIDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceDeleteHeaderDetailListAsync)GetInstance).DeleteHeaderDetailListAsync<T, T1, T2, T3, T4>(listIDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteHeaderDetailListAsync<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceDeleteHeaderDetailListAsync)GetInstance).DeleteHeaderDetailListAsync<T, T1, T2, T3, T4, T5>(listIDIdentity, idReferenceColName);
        }

        public Task<EFReturnValue> DeleteListAsync<T>(List<T> listEntity) where T : class
        {
            return ((InterfaceRepoDeleteListAsync)GetInstance).DeleteListAsync(listEntity);
        }

        public Task<EFReturnValue> DeleteListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDeleteListAsync)GetInstance).DeleteListAsync(listEntity1, listEntity2);
        }

        public Task<EFReturnValue> DeleteListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDeleteListAsync)GetInstance).DeleteListAsync(listEntity1, listEntity2, listEntity3);
        }

        public Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDeleteListAsync)GetInstance).DeleteListAsync(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDeleteListAsync)GetInstance).DeleteListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public Task<EFReturnValue> DeleteListAsync<T>(List<int> listIDIdentity) where T : class
        {
            return ((InterfaceRepoDeleteListAsync)GetInstance).DeleteListAsync<T>(listIDIdentity);
        }

        public Task<EFReturnValue> DeleteListAsync<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDeleteListAsync)GetInstance).DeleteListAsync<T1, T2>(listIDIdentity1, listIDIdentity2);
        }

        public Task<EFReturnValue> DeleteListAsync<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDeleteListAsync)GetInstance).DeleteListAsync<T1, T2, T3>(listIDIdentity1, listIDIdentity2, listIDIdentity3);
        }

        public Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDeleteListAsync)GetInstance).DeleteListAsync<T1, T2, T3, T4>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4);
        }

        public Task<EFReturnValue> DeleteListAsync<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDeleteListAsync)GetInstance).DeleteListAsync<T1, T2, T3, T4, T5>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4, listIDIdentity5);
        }

        public Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList) where T : class
        {
            return ((InterfaceRepoListAsync)GetInstance).ListDataAsync<T>(searchFieldList);
        }

        public Task<EFReturnValue> ListDataAsync<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class
        {
            return ((InterfaceRepoListAsync)GetInstance).ListDataAsync<T>(searchFieldList, sortColumn, isAscending, topTake);
        }

        public Task<EFReturnValue> ListDataAsync<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class
            where TResult : class
        {
            return ((InterfaceRepoListAsync)GetInstance).ListDataAsync<TSource, TResult>(searchFieldList, sortColumn, isAscending, topTake);
        }

        public Task<EFReturnValue> SaveAsync<T>(T entity) where T : class
        {
            return ((InterfaceRepoSaveAsync)GetInstance).SaveAsync(entity);
        }

        public Task<EFReturnValue> SaveAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoSaveAsync)GetInstance).SaveAsync(entity1, entity2);
        }

        public Task<EFReturnValue> SaveAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoSaveAsync)GetInstance).SaveAsync(entity1, entity2, entity3);
        }

        public Task<EFReturnValue> SaveAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoSaveAsync)GetInstance).SaveAsync(entity1, entity2, entity3, entity4);
        }

        public Task<EFReturnValue> SaveAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoSaveAsync)GetInstance).SaveAsync(entity1, entity2, entity3, entity4, entity5);
        }

        public Task<EFReturnValue> SaveHeaderDetailAsync<T, T1>(T tblHeader, string idReferenceColName, T1 tblDetail1)
            where T : class
            where T1 : class
        {
            return ((InterfaceRepoSaveHeaderDetailAsync)GetInstance).SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1);
        }

        public Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2)
            where T : class
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoSaveHeaderDetailAsync)GetInstance).SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1, tblDetail2);
        }

        public Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2, T3>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoSaveHeaderDetailAsync)GetInstance).SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3);
        }

        public Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoSaveHeaderDetailAsync)GetInstance).SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3, tblDetail4);
        }

        public Task<EFReturnValue> SaveHeaderDetailAsync<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4, T5 tblDetail5)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoSaveHeaderDetailAsync)GetInstance).SaveHeaderDetailAsync(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3, tblDetail4, tblDetail5);
        }

        public Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1)
            where T : class
            where T1 : class
        {
            return ((InterfaceRepoSaveHeaderDetailListAsync)GetInstance).SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1);
        }

        public Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2)
            where T : class
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoSaveHeaderDetailListAsync)GetInstance).SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2);
        }

        public Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2, T3>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoSaveHeaderDetailListAsync)GetInstance).SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3);
        }

        public Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3, List<T4> listTblDetail4)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoSaveHeaderDetailListAsync)GetInstance).SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3, listTblDetail4);
        }

        public Task<EFReturnValue> SaveHeaderDetailListAsync<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3, List<T4> listTblDetail4, List<T5> listTblDetail5)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoSaveHeaderDetailListAsync)GetInstance).SaveHeaderDetailListAsync(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3, listTblDetail4, listTblDetail5);
        }

        public Task<EFReturnValue> SaveListAsync<T>(List<T> listEntity) where T : class
        {
            return ((InterfaceRepoSaveListAsync)GetInstance).SaveListAsync(listEntity);
        }

        public Task<EFReturnValue> SaveListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoSaveListAsync)GetInstance).SaveListAsync(listEntity1, listEntity2);
        }

        public Task<EFReturnValue> SaveListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoSaveListAsync)GetInstance).SaveListAsync(listEntity1, listEntity2, listEntity3);
        }

        public Task<EFReturnValue> SaveListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoSaveListAsync)GetInstance).SaveListAsync(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public Task<EFReturnValue> SaveListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoSaveListAsync)GetInstance).SaveListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public Task<EFReturnValue> SaveUpdateAsync<T1>(T1 entity1, bool isSaveT1) where T1 : class
        {
            return ((InterfaceSaveUpdateAsync)GetInstance).SaveUpdateAsync(entity1, isSaveT1);
        }

        public Task<EFReturnValue> SaveUpdateAsync<T1, T2>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceSaveUpdateAsync)GetInstance).SaveUpdateAsync(entity1, isSaveT1, entity2, isSaveT2);
        }

        public Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceSaveUpdateAsync)GetInstance).SaveUpdateAsync(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3);
        }

        public Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3, T4>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceSaveUpdateAsync)GetInstance).SaveUpdateAsync(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4);
        }

        public Task<EFReturnValue> SaveUpdateAsync<T1, T2, T3, T4, T5>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4, T5 entity5, bool isSaveT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceSaveUpdateAsync)GetInstance).SaveUpdateAsync(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4, entity5, isSaveT5);
        }

        public Task<EFReturnValue> SaveUpdateListAsync<T1>(List<T1> listEntity1, bool isSaveT1) where T1 : class
        {
            return ((InterfaceSaveUpdateListAsync)GetInstance).SaveUpdateListAsync(listEntity1, isSaveT1);
        }

        public Task<EFReturnValue> SaveUpdateListAsync<T1, T2>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceSaveUpdateListAsync)GetInstance).SaveUpdateListAsync(listEntity1, isSaveT1, listEntity2, isSaveT2);
        }

        public Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceSaveUpdateListAsync)GetInstance).SaveUpdateListAsync(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3);
        }

        public Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3, T4>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceSaveUpdateListAsync)GetInstance).SaveUpdateListAsync(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3, listEntity4, isSaveT4);
        }

        public Task<EFReturnValue> SaveUpdateListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4, List<T5> listEntity5, bool isSaveT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceSaveUpdateListAsync)GetInstance).SaveUpdateListAsync(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3, listEntity4, isSaveT4, listEntity5, isSaveT5);
        }

        public Task<EFReturnValue> UpdateAllAsync<T>(T entity) where T : class
        {
            return ((InterfaceRepoUpdateAllAsync)GetInstance).UpdateAllAsync(entity);
        }

        public Task<EFReturnValue> UpdateAllAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoUpdateAllAsync)GetInstance).UpdateAllAsync(entity1, entity2);
        }

        public Task<EFReturnValue> UpdateAllAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoUpdateAllAsync)GetInstance).UpdateAllAsync(entity1, entity2, entity3);
        }

        public Task<EFReturnValue> UpdateAllAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoUpdateAllAsync)GetInstance).UpdateAllAsync(entity1, entity2, entity3, entity4);
        }

        public Task<EFReturnValue> UpdateAllAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoUpdateAllAsync)GetInstance).UpdateAllAsync(entity1, entity2, entity3, entity4, entity5);
        }

        public Task<EFReturnValue> UpdateAllListAsync<T>(List<T> listEntity) where T : class
        {
            return ((InterfaceRepoUpdateAllListAsync)GetInstance).UpdateAllListAsync(listEntity);
        }

        public Task<EFReturnValue> UpdateAllListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoUpdateAllListAsync)GetInstance).UpdateAllListAsync(listEntity1, listEntity2);
        }

        public Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoUpdateAllListAsync)GetInstance).UpdateAllListAsync(listEntity1, listEntity2, listEntity3);
        }

        public Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoUpdateAllListAsync)GetInstance).UpdateAllListAsync(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public Task<EFReturnValue> UpdateAllListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoUpdateAllListAsync)GetInstance).UpdateAllListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public Task<EFReturnValue> UpdateAsync<T>(T entity) where T : class
        {
            return ((InterfaceRepoUpdateAsync)GetInstance).UpdateAsync(entity);
        }

        public Task<EFReturnValue> UpdateAsync<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoUpdateAsync)GetInstance).UpdateAsync(entity1, entity2);
        }

        public Task<EFReturnValue> UpdateAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoUpdateAsync)GetInstance).UpdateAsync(entity1, entity2, entity3);
        }

        public Task<EFReturnValue> UpdateAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoUpdateAsync)GetInstance).UpdateAsync(entity1, entity2, entity3, entity4);
        }

        public Task<EFReturnValue> UpdateAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoUpdateAsync)GetInstance).UpdateAsync(entity1, entity2, entity3, entity4, entity5);
        }

        public Task<EFReturnValue> UpdateListAsync<T>(List<T> listlistEntity) where T : class
        {
            return ((InterfaceRepoUpdateListAsync)GetInstance).UpdateListAsync(listlistEntity);
        }

        public Task<EFReturnValue> UpdateListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoUpdateListAsync)GetInstance).UpdateListAsync(listEntity1, listEntity2);
        }

        public Task<EFReturnValue> UpdateListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoUpdateListAsync)GetInstance).UpdateListAsync(listEntity1, listEntity2, listEntity3);
        }

        public Task<EFReturnValue> UpdateListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoUpdateListAsync)GetInstance).UpdateListAsync(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public Task<EFReturnValue> UpdateListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoUpdateListAsync)GetInstance).UpdateListAsync(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }
    }
}
