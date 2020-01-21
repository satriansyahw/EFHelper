using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryDeleteHeaderDetail
{
    public interface InterfaceDeleteHeaderDetail
    {
        bool DeleteHeaderDetail<T, T1>(int IDIdentity, string idReferenceColName) where T : class where T1 : class;
        bool DeleteHeaderDetail<T, T1, T2>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        bool DeleteHeaderDetail<T, T1, T2, T3>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        bool DeleteHeaderDetail<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        bool DeleteHeaderDetail<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceDeleteHeaderDetailAsync
    {
        Task<bool> DeleteHeaderDetailAsync<T, T1>(int IDIdentity, string idReferenceColName) where T : class where T1 : class;
        Task<bool> DeleteHeaderDetailAsync<T, T1, T2>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        Task<bool> DeleteHeaderDetailAsync<T, T1, T2, T3>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        Task<bool> DeleteHeaderDetailAsync<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> DeleteHeaderDetailAsync<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceDeleteHeaderDetailList
    {
        bool DeleteHeaderDetailList<T, T1>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class;
        bool DeleteHeaderDetailList<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        bool DeleteHeaderDetailList<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        bool DeleteHeaderDetailList<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        bool DeleteHeaderDetailList<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceDeleteHeaderDetailListAsync
    {
        Task<bool> DeleteHeaderDetailListAsync<T, T1>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class;
        Task<bool> DeleteHeaderDetailListAsync<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        Task<bool> DeleteHeaderDetailListAsync<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        Task<bool> DeleteHeaderDetailListAsync<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> DeleteHeaderDetailListAsync<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceDeleteHeaderDetailActiveBool
    {
        bool DeleteHeaderDetailActiveBool<T, T1>(int IDIdentity, string idReferenceColName) where T : class where T1 : class;
        bool DeleteHeaderDetailActiveBool<T, T1, T2>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        bool DeleteHeaderDetailActiveBool<T, T1, T2, T3>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        bool DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        bool DeleteHeaderDetailActiveBool<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceDeleteHeaderDetailActiveBoolAsync
    {
        Task<bool> DeleteHeaderDetailActiveBoolAsync<T, T1>(int IDIdentity, string idReferenceColName) where T : class where T1 : class;
        Task<bool> DeleteHeaderDetailActiveBoolAsync<T, T1, T2>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        Task<bool> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        Task<bool> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> DeleteHeaderDetailActiveBoolAsync<T, T1, T2, T3, T4, T5>(int IDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceDeleteHeaderDetailActiveBoolList
    {
        bool DeleteHeaderDetailActiveBoolList<T, T1>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class;
        bool DeleteHeaderDetailActiveBoolList<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        bool DeleteHeaderDetailActiveBoolList<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        bool DeleteHeaderDetailActiveBoolList<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        bool DeleteHeaderDetailActiveBoolList<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceDeleteHeaderDetailActiveBoolListAsync
    {
        Task<bool> DeleteHeaderDetailActiveBoolListAsync<T, T1>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class;
        Task<bool> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class;
        Task<bool> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class;
        Task<bool> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> DeleteHeaderDetailActiveBoolListAsync<T, T1, T2, T3, T4, T5>(List<int> listIDIdentity, string idReferenceColName) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
}
