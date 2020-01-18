using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFHelper.RepositoryDelete
{
    public interface InterfaceRepoDelete
    {
        bool Delete<T>(T entity) where T : class;
        bool Delete<T>(int IDIdentity) where T : class;
    }
    public interface InterfaceRepoDeleteList
    {
        bool DeleteList<T>(List<T> listEntity) where T : class;
        bool DeleteList<T>(List<int> listIDIdentity) where T : class;
    }

    public interface InterfaceRepoDeleteAsync
    {
        Task<bool> DeleteAsync<T>(T entity) where T : class;
        Task<bool> DeleteAsync<T>(int IDIdentity) where T : class;
    }
    public interface InterfaceRepoDeleteListAsync
    {
        Task<bool> DeleteListAsync<T>(List<T> listEntity) where T : class;
        Task<bool> DeleteListAsync<T>(List<int> listIDIdentity) where T : class;
    }
    public interface InterfaceRepoDeleteActiveBool
    {
        bool DeleteActiveBool<T>(T entity) where T : class;
        bool DeleteActiveBool<T>(int IDIdentity) where T : class;
    }
    public interface InterfaceRepoDeleteActiveBoolList
    {
        bool DeleteActiveBoolList<T>(List<T> listEntity) where T : class;
        bool DeleteActiveBoolList<T>(List<int> listIDIdentity) where T : class;
    }
}
