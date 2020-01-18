using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.RepositoryUpdate
{
    public interface InterfaceRepoUpdate
    {
        bool Update<T>(T entity) where T : class;
        bool Update<T1, T2>(T1 entity1, T2 entity2) where T1 : class where T2 : class;
        bool Update<T1, T2, T3>(T1 entity1, T2 entity2, T3 entity3) where T1 : class where T2 : class where T3 : class;
        bool Update<T1, T2, T3, T4>(T1 entity1, T2 entity2, T3 entity3, T4 entity4) where T1 : class where T2 : class where T3 : class where T4 : class;
        bool Update<T1, T2, T3, T4, T5>(T1 entity1, T2 entity2, T3 entity3, T4 entity4, T5 entity5) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class;



    }
    public interface InterfaceRepoUpdateList
    {
        bool UpdateList<T>(List<T> listEntity) where T : class;

    }

    public interface InterfaceRepoUpdateAll
    {
        bool UpdateAll<T>(T entity) where T : class;

    }
    public interface InterfaceRepoUpdateAllList
    {
        bool UpdateAllList<T>(List<T> listEntity) where T : class;

    }
}
