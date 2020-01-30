using System;
using System.Collections.Generic;
using System.Linq;
using EFHelper.ColumnHelper;
using EFHelper.Context;
using EFHelper.DBCommandList;
using EFHelper.EntityPreparation;
using EFHelper.Filtering;
using EFHelper.MiscClass;

namespace EFHelper.RepositoryList
{
    public class RepoList : EFRepoList
    {       
        private EFReturnValue eFReturn = new EFReturnValue { IsSuccessConnection = false, IsSuccessQuery = false, ErrorMessage = ErrorMessage.EntityCannotBeNull, ReturnValue = null };
        private DBCommandRepoList listDBCommand = new DBCommandRepoList();
        private static RepoList instance;
        public static RepoList GetInstance
        {
            get
            {
                if (instance == null) instance = new RepoList();
                return instance;
            }
        }
        public override EFReturnValue ListData<T>(List<SearchField> searchFieldList)
        {
            if (!ColumnPropGet.GetInstance.GetCheckIsExistDatetimeAndLike<T>(searchFieldList))
                eFReturn = base.ListData<T>(searchFieldList);
            else
                eFReturn = listDBCommand.ListData<T>(searchFieldList);
            return eFReturn;
        }
        public override EFReturnValue ListData<T>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)
        {
            if (!ColumnPropGet.GetInstance.GetCheckIsExistDatetimeAndLike<T>(searchFieldList))
                eFReturn = base.ListData<T>(searchFieldList, sortColumn, isAscending, topTake);
            else
                eFReturn = listDBCommand.ListData<T>(searchFieldList,sortColumn,isAscending,topTake);
            return eFReturn;
        }
        public override EFReturnValue ListData<TSource, TResult>(List<SearchField> searchFieldList, string sortColumn, bool isAscending, int topTake)         
        {
            if (!ColumnPropGet.GetInstance.GetCheckIsExistDatetimeAndLike<TSource>(searchFieldList))
                eFReturn = base.ListData<TSource, TResult>(searchFieldList, sortColumn, isAscending, topTake);
            else
                eFReturn = listDBCommand.ListData<TSource,TResult>(searchFieldList,sortColumn,isAscending,topTake);
            return eFReturn;
        }

        public override EFReturnValue ListData<T>()
        {
            eFReturn = base.ListData<T>();
            return eFReturn;
        }

    }
}
