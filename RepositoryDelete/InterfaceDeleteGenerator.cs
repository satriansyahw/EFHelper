using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryDelete
{
    public interface InterfaceRepoDelete
    {
       
        bool Delete<T>(int IDIdentity) where T : class;
        bool Delete<T1, T2>(int IDIdentity1, int IDIdentity2) where T1 : class where T2 : class;
        bool Delete<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3) where T1 : class where T2 : class where T3 : class;
        bool Delete<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool Delete<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        bool Delete<T>(T entity) where T : class;
        bool Delete<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        bool Delete<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        bool Delete<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool Delete<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoDeleteList
    {
        bool DeleteList<T>(List<T> listEntity) where T : class;
        bool DeleteList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2) where T1 : class where T2 : class;
        bool DeleteList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3) where T1 : class where T2 : class where T3 : class;
        bool DeleteList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool DeleteList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        bool DeleteList<T>(List<int> listIDIdentity) where T : class;
        bool DeleteList<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2) where T1 : class where T2 : class;
        bool DeleteList<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3) where T1 : class where T2 : class where T3 : class;
        bool DeleteList<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool DeleteList<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }

    public interface InterfaceRepoDeleteAsync
    {
        Task<bool> DeleteAsync<T>(int IDIdentity) where T : class;
        Task<bool> DeleteAsync<T1, T2>(int IDIdentity1, int IDIdentity2) where T1 : class where T2 : class;
        Task<bool> DeleteAsync<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3) where T1 : class where T2 : class where T3 : class;
        Task<bool> DeleteAsync<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> DeleteAsync<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        Task<bool> DeleteAsync<T>(T entity) where T : class;
        Task<bool> DeleteAsync<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        Task<bool> DeleteAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        Task<bool> DeleteAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> DeleteAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoDeleteListAsync
    {

        Task<bool> DeleteListAsync<T>(List<T> listEntity) where T : class;
        Task<bool> DeleteListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2) where T1 : class where T2 : class;
        Task<bool> DeleteListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3) where T1 : class where T2 : class where T3 : class;
        Task<bool> DeleteListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> DeleteListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        Task<bool> DeleteListAsync<T>(List<int> listIDIdentity) where T : class;
        Task<bool> DeleteListAsync<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2) where T1 : class where T2 : class;
        Task<bool> DeleteListAsync<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3) where T1 : class where T2 : class where T3 : class;
        Task<bool> DeleteListAsync<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> DeleteListAsync<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;


    }
    public interface InterfaceRepoDeleteActiveBool
    {
        bool DeleteActiveBool<T>(int IDIdentity) where T : class;
        bool DeleteActiveBool<T1, T2>(int IDIdentity1, int IDIdentity2) where T1 : class where T2 : class;
        bool DeleteActiveBool<T1, T2, T3>(int IDIdentity1, int IDIdentity2, int IDIdentity3) where T1 : class where T2 : class where T3 : class;
        bool DeleteActiveBool<T1, T2, T3, T4>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool DeleteActiveBool<T1, T2, T3, T4, T5>(int IDIdentity1, int IDIdentity2, int IDIdentity3, int IDIdentity4, int IDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        bool DeleteActiveBool<T>(T entity) where T : class;
        bool DeleteActiveBool<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        bool DeleteActiveBool<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        bool DeleteActiveBool<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool DeleteActiveBool<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
      
    }
    public interface InterfaceRepoDeleteActiveBoolList
    {

        bool DeleteActiveBoolList<T>(List<T> listEntity) where T : class;
        bool DeleteActiveBoolList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2) where T1 : class where T2 : class;
        bool DeleteActiveBoolList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3) where T1 : class where T2 : class where T3 : class;
        bool DeleteActiveBoolList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool DeleteActiveBoolList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        bool DeleteActiveBoolList<T>(List<int> listIDIdentity) where T : class;
        bool DeleteActiveBoolList<T1, T2>(List<int> listIDIdentity1, List<int> listIDIdentity2) where T1 : class where T2 : class;
        bool DeleteActiveBoolList<T1, T2, T3>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3) where T1 : class where T2 : class where T3 : class;
        bool DeleteActiveBoolList<T1, T2, T3, T4>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool DeleteActiveBoolList<T1, T2, T3, T4, T5>(List<int> listIDIdentity1, List<int> listIDIdentity2, List<int> listIDIdentity3, List<int> listIDIdentity4, List<int> listIDIdentity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;


    }
    public interface InterfaceRepoDeleteActiveBoolAsync
    {
        Task<bool> DeleteActiveBoolAsync<T>(T entity) where T : class;
        Task<bool> DeleteActiveBoolAsync<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        Task<bool> DeleteActiveBoolAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        Task<bool> DeleteActiveBoolAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> DeleteActiveBoolAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

        Task<bool> DeleteActiveBoolAsync<T>(int IDIdentity) where T : class;

    }
    public interface InterfaceRepoDeleteActiveBoolListAsync
    {
        Task<bool> DeleteActiveBoolListAsync<T>(List<T> listEntity) where T : class;
        Task<bool> DeleteActiveBoolListAsync<T>(List<int> listIDIdentity) where T : class;
    }

}
