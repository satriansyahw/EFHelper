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
    public class RepoWrapper: DBContextBantuan,InterfaceRepoSave, InterfaceRepoSaveList, InterfaceRepoSaveHeaderDetail, InterfaceRepoSaveHeaderDetailList, InterfaceSaveUpdate, InterfaceSaveUpdateList
        , InterfaceRepoUpdate, InterfaceRepoUpdateList, InterfaceRepoUpdateAll, InterfaceRepoUpdateAllList, InterfaceRepoDelete, InterfaceRepoDeleteList, InterfaceRepoDeleteActiveBool, InterfaceRepoDeleteActiveBoolList
        , InterfaceDeleteHeaderDetail, InterfaceDeleteHeaderDetailList, InterfaceDeleteHeaderDetailActiveBool, InterfaceDeleteHeaderDetailActiveBoolList
        , InterfaceRepoList
    {
        private static RepoWrapper instance;
        public new static RepoWrapper GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoWrapper();
                return instance;
            }
        }
        public RepoWrapper()
        {

        }
        public RepoWrapper(DbContext dbContext)
        {
            DBContextInfo.MyDbContext = dbContext;
        }
        public override DbContext CreateConnectionContext()
        {
            return this.CreateConnectionContext();
        }

        public override void SetConnectionContext(DbContext dbContext)
        {
            this.SetConnectionContext(dbContext);
        }
        public EFReturnValue Delete<T>(int IDIdentity) where T : class
        {
            return ((InterfaceRepoDelete)GetInstance).Delete<T>(IDIdentity);
        }

        public EFReturnValue Delete<T1, T2>(int IDIdentity1, int IDIdentity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDelete)GetInstance).Delete<T1, T2>(IDIdentity1, IDIdentity2);
        }

        public EFReturnValue Delete<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDelete)GetInstance).Delete<T1, T2, T3>(IDIdentity1, IDIdentity2, IDIdentity3);
        }

        public EFReturnValue Delete<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDelete)GetInstance).Delete<T1, T2, T3, T4>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4);
        }

        public EFReturnValue Delete<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDelete)GetInstance).Delete<T1, T2, T3, T4, T5>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4, IDIdentity5);
        }

        public EFReturnValue Delete<T>(T entity) where T : class
        {
            return ((InterfaceRepoDelete)GetInstance).Delete(entity);
        }

        public EFReturnValue Delete<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDelete)GetInstance).Delete(entity1, entity2);
        }

        public EFReturnValue Delete<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDelete)GetInstance).Delete(entity1, entity2, entity3);
        }

        public EFReturnValue Delete<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDelete)GetInstance).Delete(entity1, entity2, entity3, entity4);
        }

        public EFReturnValue Delete<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDelete)GetInstance).Delete(entity1, entity2, entity3, entity4, entity5);
        }

        public EFReturnValue DeleteActiveBool<T>(int IDIdentity) where T : class
        {
            return ((InterfaceRepoDeleteActiveBool)GetInstance).DeleteActiveBool<T>(IDIdentity);
        }

        public EFReturnValue DeleteActiveBool<T1, T2>(int IDIdentity1, int IDIdentity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDeleteActiveBool)GetInstance).DeleteActiveBool<T1, T2>(IDIdentity1, IDIdentity2);
        }

        public EFReturnValue DeleteActiveBool<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDeleteActiveBool)GetInstance).DeleteActiveBool<T1, T2, T3>(IDIdentity1, IDIdentity2, IDIdentity3);
        }

        public EFReturnValue DeleteActiveBool<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDeleteActiveBool)GetInstance).DeleteActiveBool<T1, T2, T3, T4>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4);
        }

        public EFReturnValue DeleteActiveBool<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDeleteActiveBool)GetInstance).DeleteActiveBool<T1, T2, T3, T4, T5>(IDIdentity1, IDIdentity2, IDIdentity3, IDIdentity4, IDIdentity5);
        }

        public EFReturnValue DeleteActiveBool<T>(T entity) where T : class
        {
            return ((InterfaceRepoDeleteActiveBool)GetInstance).DeleteActiveBool(entity);
        }

        public EFReturnValue DeleteActiveBool<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDeleteActiveBool)GetInstance).DeleteActiveBool(entity1, entity2);
        }

        public EFReturnValue DeleteActiveBool<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDeleteActiveBool)GetInstance).DeleteActiveBool(entity1, entity2, entity3);
        }

        public EFReturnValue DeleteActiveBool<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDeleteActiveBool)GetInstance).DeleteActiveBool(entity1, entity2, entity3, entity4);
        }

        public EFReturnValue DeleteActiveBool<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDeleteActiveBool)GetInstance).DeleteActiveBool(entity1, entity2, entity3, entity4, entity5);
        }

        public EFReturnValue DeleteActiveBoolList<T>(List<T> listEntity) where T : class
        {
            return ((InterfaceRepoDeleteActiveBoolList)GetInstance).DeleteActiveBoolList(listEntity);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDeleteActiveBoolList)GetInstance).DeleteActiveBoolList(listEntity1, listEntity2);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDeleteActiveBoolList)GetInstance).DeleteActiveBoolList(listEntity1, listEntity2, listEntity3);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDeleteActiveBoolList)GetInstance).DeleteActiveBoolList(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDeleteActiveBoolList)GetInstance).DeleteActiveBoolList(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public EFReturnValue DeleteActiveBoolList<T>(List<int> listIDIdentity) where T : class
        {
            return ((InterfaceRepoDeleteActiveBoolList)GetInstance).DeleteActiveBoolList<T>(listIDIdentity);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDeleteActiveBoolList)GetInstance).DeleteActiveBoolList<T1, T2>(listIDIdentity1, listIDIdentity2);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDeleteActiveBoolList)GetInstance).DeleteActiveBoolList<T1, T2, T3>(listIDIdentity1, listIDIdentity2, listIDIdentity3);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDeleteActiveBoolList)GetInstance).DeleteActiveBoolList<T1, T2, T3, T4>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4);
        }

        public EFReturnValue DeleteActiveBoolList<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDeleteActiveBoolList)GetInstance).DeleteActiveBoolList<T1, T2, T3, T4, T5>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4, listIDIdentity5);
        }

        public EFReturnValue DeleteHeaderDetail<T, T1>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return ((InterfaceDeleteHeaderDetail)GetInstance).DeleteHeaderDetail<T, T1>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetail<T, T1, T2>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return ((InterfaceDeleteHeaderDetail)GetInstance).DeleteHeaderDetail<T, T1, T2>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetail<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceDeleteHeaderDetail)GetInstance).DeleteHeaderDetail<T, T1, T2, T3>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetail<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceDeleteHeaderDetail)GetInstance).DeleteHeaderDetail<T, T1, T2, T3, T4>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetail<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceDeleteHeaderDetail)GetInstance).DeleteHeaderDetail<T, T1, T2, T3, T4, T5>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBool<T, T1>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBool)GetInstance).DeleteHeaderDetailActiveBool<T, T1>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBool)GetInstance).DeleteHeaderDetailActiveBool<T, T1, T2>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2, T3>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBool)GetInstance).DeleteHeaderDetailActiveBool<T, T1, T2, T3>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBool)GetInstance).DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBool)GetInstance).DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4, T5>(IDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolList)GetInstance).DeleteHeaderDetailActiveBoolList<T, T1>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolList)GetInstance).DeleteHeaderDetailActiveBoolList<T, T1, T2>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolList)GetInstance).DeleteHeaderDetailActiveBoolList<T, T1, T2, T3>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolList)GetInstance).DeleteHeaderDetailActiveBoolList<T, T1, T2, T3, T4>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailActiveBoolList<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceDeleteHeaderDetailActiveBoolList)GetInstance).DeleteHeaderDetailActiveBoolList<T, T1, T2, T3, T4, T5>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailList<T, T1>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
        {
            return ((InterfaceDeleteHeaderDetailList)GetInstance).DeleteHeaderDetailList<T, T1>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailList<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
        {
            return ((InterfaceDeleteHeaderDetailList)GetInstance).DeleteHeaderDetailList<T, T1, T2>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailList<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceDeleteHeaderDetailList)GetInstance).DeleteHeaderDetailList<T, T1, T2, T3>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailList<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceDeleteHeaderDetailList)GetInstance).DeleteHeaderDetailList<T, T1, T2, T3, T4>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteHeaderDetailList<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceDeleteHeaderDetailList)GetInstance).DeleteHeaderDetailList<T, T1, T2, T3, T4, T5>(listIDIdentity, idReferenceColName);
        }

        public EFReturnValue DeleteList<T>(List<T> listEntity) where T : class
        {
            return ((InterfaceRepoDeleteList)GetInstance).DeleteList(listEntity);
        }

        public EFReturnValue DeleteList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDeleteList)GetInstance).DeleteList(listEntity1, listEntity2);
        }

        public EFReturnValue DeleteList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDeleteList)GetInstance).DeleteList(listEntity1, listEntity2, listEntity3);
        }

        public EFReturnValue DeleteList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDeleteList)GetInstance).DeleteList(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public EFReturnValue DeleteList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDeleteList)GetInstance).DeleteList(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public EFReturnValue DeleteList<T>(List<int> listIDIdentity) where T : class
        {
            return ((InterfaceRepoDeleteList)GetInstance).DeleteList<T>(listIDIdentity);
        }

        public EFReturnValue DeleteList<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoDeleteList)GetInstance).DeleteList<T1, T2>(listIDIdentity1, listIDIdentity2);
        }

        public EFReturnValue DeleteList<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoDeleteList)GetInstance).DeleteList<T1, T2, T3>(listIDIdentity1, listIDIdentity2, listIDIdentity3);
        }

        public EFReturnValue DeleteList<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoDeleteList)GetInstance).DeleteList<T1, T2, T3, T4>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4);
        }

        public EFReturnValue DeleteList<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoDeleteList)GetInstance).DeleteList<T1, T2, T3, T4, T5>(listIDIdentity1, listIDIdentity2, listIDIdentity3, listIDIdentity4, listIDIdentity5);
        }

        public EFReturnValue ListData<T>(List<SearchField> searchFieldList) where T : class
        {
            return ((InterfaceRepoList)GetInstance).ListData<T>(searchFieldList);
        }

        public EFReturnValue ListData<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake) where T : class
        {
            return ((InterfaceRepoList)GetInstance).ListData<T>(searchFieldList, sortColumn, isAscending, topTake);
        }

        public EFReturnValue ListData<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
            where TSource : class
            where TResult : class
        {
            return ((InterfaceRepoList)GetInstance).ListData<TSource, TResult>(searchFieldList, sortColumn, isAscending, topTake);
        }
      
        public EFReturnValue Save<T>(T entity) where T : class
        {
            return ((InterfaceRepoSave)GetInstance).Save(entity);
        }

        public EFReturnValue Save<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class     where T2 : class
        {
            return ((InterfaceRepoSave)GetInstance).Save(entity1, entity2);
        }

        public EFReturnValue Save<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoSave)GetInstance).Save(entity1, entity2, entity3);
        }

        public EFReturnValue Save<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoSave)GetInstance).Save(entity1, entity2, entity3, entity4);
        }

        public EFReturnValue Save<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoSave)GetInstance).Save(entity1, entity2, entity3, entity4, entity5);
        }

        public EFReturnValue SaveHeaderDetail<T, T1>(T tblHeader, string idReferenceColName, T1 tblDetail1)
            where T : class
            where T1 : class
        {
            return ((InterfaceRepoSaveHeaderDetail)GetInstance).SaveHeaderDetail(tblHeader, idReferenceColName, tblDetail1);
        }

        public EFReturnValue SaveHeaderDetail<T, T1, T2>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2)
            where T : class
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoSaveHeaderDetail)GetInstance).SaveHeaderDetail(tblHeader, idReferenceColName, tblDetail1, tblDetail2);
        }

        public EFReturnValue SaveHeaderDetail<T, T1, T2, T3>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoSaveHeaderDetail)GetInstance).SaveHeaderDetail(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3);
        }

        public EFReturnValue SaveHeaderDetail<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoSaveHeaderDetail)GetInstance).SaveHeaderDetail(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3, tblDetail4);
        }

        public EFReturnValue SaveHeaderDetail<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4, T5 tblDetail5)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoSaveHeaderDetail)GetInstance).SaveHeaderDetail(tblHeader, idReferenceColName, tblDetail1, tblDetail2, tblDetail3, tblDetail4, tblDetail5);
        }

        public EFReturnValue SaveHeaderDetailList<T, T1>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1)
            where T : class
            where T1 : class
        {
            return ((InterfaceRepoSaveHeaderDetailList)GetInstance).SaveHeaderDetailList(tblHeader, idReferenceColName, listTblDetail1);
        }

        public EFReturnValue SaveHeaderDetailList<T, T1, T2>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2)
            where T : class
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoSaveHeaderDetailList)GetInstance).SaveHeaderDetailList(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2);
        }

        public EFReturnValue SaveHeaderDetailList<T, T1, T2, T3>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoSaveHeaderDetailList)GetInstance).SaveHeaderDetailList(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3);
        }

        public EFReturnValue SaveHeaderDetailList<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3, List<T4> listTblDetail4)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoSaveHeaderDetailList)GetInstance).SaveHeaderDetailList(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3, listTblDetail4);
        }

        public EFReturnValue SaveHeaderDetailList<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, List<T1> listTblDetail1, List<T2> listTblDetail2, List<T3> listTblDetail3, List<T4> listTblDetail4, List<T5> listTblDetail5)
            where T : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoSaveHeaderDetailList)GetInstance).SaveHeaderDetailList(tblHeader, idReferenceColName, listTblDetail1, listTblDetail2, listTblDetail3, listTblDetail4, listTblDetail5);
        }

        public EFReturnValue SaveList<T>(List<T> listEntity) where T : class
        {
            return ((InterfaceRepoSaveList)GetInstance).SaveList(listEntity);
        }

        public EFReturnValue SaveList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoSaveList)GetInstance).SaveList(listEntity1, listEntity2);
        }

        public EFReturnValue SaveList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoSaveList)GetInstance).SaveList(listEntity1, listEntity2, listEntity3);
        }

        public EFReturnValue SaveList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoSaveList)GetInstance).SaveList(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public EFReturnValue SaveList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoSaveList)GetInstance).SaveList(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public EFReturnValue SaveUpdate<T1>(T1 entity1, bool isSaveT1) where T1 : class
        {
            return ((InterfaceSaveUpdate)GetInstance).SaveUpdate(entity1, isSaveT1);
        }

        public EFReturnValue SaveUpdate<T1, T2>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceSaveUpdate)GetInstance).SaveUpdate(entity1, isSaveT1, entity2, isSaveT2);
        }

        public EFReturnValue SaveUpdate<T1, T2, T3>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceSaveUpdate)GetInstance).SaveUpdate(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3);
        }

        public EFReturnValue SaveUpdate<T1, T2, T3, T4>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceSaveUpdate)GetInstance).SaveUpdate(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4);
        }

        public EFReturnValue SaveUpdate<T1, T2, T3, T4, T5>(T1 entity1, bool isSaveT1, T2 entity2, bool isSaveT2, T3 entity3, bool isSaveT3, T4 entity4, bool isSaveT4, T5 entity5, bool isSaveT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceSaveUpdate)GetInstance).SaveUpdate(entity1, isSaveT1, entity2, isSaveT2, entity3, isSaveT3, entity4, isSaveT4, entity5, isSaveT5);
        }

        public EFReturnValue SaveUpdateList<T1>(List<T1> listEntity1, bool isSaveT1) where T1 : class
        {
            return ((InterfaceSaveUpdateList)GetInstance).SaveUpdateList(listEntity1, isSaveT1);
        }

        public EFReturnValue SaveUpdateList<T1, T2>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceSaveUpdateList)GetInstance).SaveUpdateList(listEntity1, isSaveT1, listEntity2, isSaveT2);
        }

        public EFReturnValue SaveUpdateList<T1, T2, T3>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceSaveUpdateList)GetInstance).SaveUpdateList(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3);
        }

        public EFReturnValue SaveUpdateList<T1, T2, T3, T4>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceSaveUpdateList)GetInstance).SaveUpdateList(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3, listEntity4, isSaveT4);
        }

        public EFReturnValue SaveUpdateList<T1, T2, T3, T4, T5>(List<T1> listEntity1, bool isSaveT1, List<T2> listEntity2, bool isSaveT2, List<T3> listEntity3, bool isSaveT3, List<T4> listEntity4, bool isSaveT4, List<T5> listEntity5, bool isSaveT5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceSaveUpdateList)GetInstance).SaveUpdateList(listEntity1, isSaveT1, listEntity2, isSaveT2, listEntity3, isSaveT3, listEntity4, isSaveT4, listEntity5, isSaveT5);
        }

        public EFReturnValue Update<T>(T entity) where T : class
        {
            return ((InterfaceRepoUpdate)GetInstance).Update(entity);
        }

        public EFReturnValue Update<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoUpdate)GetInstance).Update(entity1, entity2);
        }

        public EFReturnValue Update<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoUpdate)GetInstance).Update(entity1, entity2, entity3);
        }

        public EFReturnValue Update<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoUpdate)GetInstance).Update(entity1, entity2, entity3, entity4);
        }

        public EFReturnValue Update<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoUpdate)GetInstance).Update(entity1, entity2, entity3, entity4, entity5);
        }

        public EFReturnValue UpdateAll<T>(T entity) where T : class
        {
            return ((InterfaceRepoUpdateAll)GetInstance).UpdateAll(entity);
        }

        public EFReturnValue UpdateAll<T1, T2>(T1 entity1, T2 entity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoUpdateAll)GetInstance).UpdateAll(entity1, entity2);
        }

        public EFReturnValue UpdateAll<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoUpdateAll)GetInstance).UpdateAll(entity1, entity2, entity3);
        }

        public EFReturnValue UpdateAll<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoUpdateAll)GetInstance).UpdateAll(entity1, entity2, entity3, entity4);
        }

        public EFReturnValue UpdateAll<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoUpdateAll)GetInstance).UpdateAll(entity1, entity2, entity3, entity4, entity5);
        }

        public EFReturnValue UpdateAllList<T>(List<T> listEntity) where T : class
        {
            return ((InterfaceRepoUpdateAllList)GetInstance).UpdateAllList(listEntity);
        }

        public EFReturnValue UpdateAllList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoUpdateAllList)GetInstance).UpdateAllList(listEntity1, listEntity2);
        }

        public EFReturnValue UpdateAllList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoUpdateAllList)GetInstance).UpdateAllList(listEntity1, listEntity2, listEntity3);
        }

        public EFReturnValue UpdateAllList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoUpdateAllList)GetInstance).UpdateAllList(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public EFReturnValue UpdateAllList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoUpdateAllList)GetInstance).UpdateAllList(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }

        public EFReturnValue UpdateList<T>(List<T> listlistEntity) where T : class
        {
            return ((InterfaceRepoUpdateList)GetInstance).UpdateList(listlistEntity);
        }

        public EFReturnValue UpdateList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2)
            where T1 : class
            where T2 : class
        {
            return ((InterfaceRepoUpdateList)GetInstance).UpdateList(listEntity1, listEntity2);
        }

        public EFReturnValue UpdateList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return ((InterfaceRepoUpdateList)GetInstance).UpdateList(listEntity1, listEntity2, listEntity3);
        }

        public EFReturnValue UpdateList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return ((InterfaceRepoUpdateList)GetInstance).UpdateList(listEntity1, listEntity2, listEntity3, listEntity4);
        }

        public EFReturnValue UpdateList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return ((InterfaceRepoUpdateList)GetInstance).UpdateList(listEntity1, listEntity2, listEntity3, listEntity4, listEntity5);
        }
    }
   
}
