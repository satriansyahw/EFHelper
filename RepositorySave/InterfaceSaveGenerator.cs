using EFHelper.MiscClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositorySave
{
    public interface InterfaceRepoSave
    {
        T Save<T>(T entity) where T : class;
        bool Save<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        bool Save<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        bool Save<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool Save<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoSaveList
    {
        IEnumerable<T> SaveList<T>(List<T> listEntity) where T : class;
        bool SaveList<T1, T2>(List<T1> listEntity1, List<T2> listEntity2) where T1 : class where T2 : class;
        bool SaveList<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3) where T1 : class where T2 : class where T3 : class;
        bool SaveList<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool SaveList<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoSaveHeaderDetail
    {
        EFReturnValue<T> SaveHeaderDetail<T, T1>(T tblHeader, string idReferenceColName, T1 tblDetail1) where T : class where T1 : class;
        EFReturnValue<T> SaveHeaderDetail<T, T1, T2>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2) where T : class where T1 : class where T2 : class;
        EFReturnValue<T> SaveHeaderDetail<T, T1, T2, T3>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3) where T : class where T1 : class where T2 : class where T3 : class;
        EFReturnValue<T> SaveHeaderDetail<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue<T> SaveHeaderDetail<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4, T5 tblDetail5) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoSaveHeaderDetailList
    {
        EFReturnValue<T> SaveHeaderDetail<T, T1>(T tblHeader, string idReferenceColName, List<T1> tblDetail1) where T : class where T1 : class;
        EFReturnValue<T> SaveHeaderDetail<T, T1, T2>(T tblHeader, string idReferenceColName, List<T1> tblDetail1, List<T2> tblDetail2) where T : class where T1 : class where T2 : class;
        EFReturnValue<T> SaveHeaderDetail<T, T1, T2, T3>(T tblHeader, string idReferenceColName, List<T1> tblDetail1, List<T2> tblDetail2, List<T3> tblDetail3) where T : class where T1 : class where T2 : class where T3 : class;
        EFReturnValue<T> SaveHeaderDetail<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, List<T1> tblDetail1, List<T2> tblDetail2, List<T3> tblDetail3, List<T4> tblDetail4) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        EFReturnValue<T> SaveHeaderDetail<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, List<T1> tblDetail1, List<T2> tblDetail2, List<T3> tblDetail3, List<T4> tblDetail4, List<T5> tblDetail5) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }

    public interface InterfaceRepoSaveAsync
    {      
        Task<T> SaveAsync<T>(T entity) where T : class;
        Task<bool> SaveAsync<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        Task<bool> SaveAsync<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        Task<bool> SaveAsync<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> SaveAsync<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;

    }
    public interface InterfaceRepoSaveListAsync
    {
        Task<IEnumerable<T>> SaveListAsync<T>(List<T> listEntity) where T : class;
        Task<bool> SaveListAsync<T1, T2>(List<T1> listEntity1, List<T2> listEntity2) where T1 : class where T2 : class;
        Task<bool> SaveListAsync<T1, T2, T3>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3) where T1 : class where T2 : class where T3 : class;
        Task<bool> SaveListAsync<T1, T2, T3, T4>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<bool> SaveListAsync<T1, T2, T3, T4, T5>(List<T1> listEntity1, List<T2> listEntity2, List<T3> listEntity3, List<T4> listEntity4, List<T5> listEntity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoSaveHeaderDetailAsync
    {
        Task<EFReturnValue<T>> SaveHeaderDetail<T, T1>(T tblHeader, string idReferenceColName, T1 tblDetail1) where T : class where T1 : class;
        Task<EFReturnValue<T>> SaveHeaderDetail<T, T1, T2>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2) where T : class where T1 : class where T2 : class;
        Task<EFReturnValue<T>> SaveHeaderDetail<T, T1, T2, T3>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3) where T : class where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue<T>> SaveHeaderDetail<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue<T>> SaveHeaderDetail<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, T1 tblDetail1, T2 tblDetail2, T3 tblDetail3, T4 tblDetail4, T5 tblDetail5) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
    public interface InterfaceRepoSaveHeaderDetailListAsync
    {
        Task<EFReturnValue<T>> SaveHeaderDetail<T, T1>(T tblHeader, string idReferenceColName, List<T1> tblDetail1) where T : class where T1 : class;
        Task<EFReturnValue<T>> SaveHeaderDetail<T, T1, T2>(T tblHeader, string idReferenceColName, List<T1> tblDetail1, List<T2> tblDetail2) where T : class where T1 : class where T2 : class;
        Task<EFReturnValue<T>> SaveHeaderDetail<T, T1, T2, T3>(T tblHeader, string idReferenceColName, List<T1> tblDetail1, List<T2> tblDetail2, List<T3> tblDetail3) where T : class where T1 : class where T2 : class where T3 : class;
        Task<EFReturnValue<T>> SaveHeaderDetail<T, T1, T2, T3, T4>(T tblHeader, string idReferenceColName, List<T1> tblDetail1, List<T2> tblDetail2, List<T3> tblDetail3, List<T4> tblDetail4) where T : class where T1 : class where T2 : class where T3 : class where T4 : class;
        Task<EFReturnValue<T>> SaveHeaderDetail<T, T1, T2, T3, T4, T5>(T tblHeader, string idReferenceColName, List<T1> tblDetail1, List<T2> tblDetail2, List<T3> tblDetail3, List<T4> tblDetail4, List<T5> tblDetail5) where T : class where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;
    }
}
