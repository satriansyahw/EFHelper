using System.Collections.Generic;
using System.Linq;
using EFHelper.EntityPreparation;
using EFHelper.Filtering;

namespace EFHelper.Repository
{
    public class RepoList : InterfaceRepoList
    {
        public IEnumerable<T> ListData<T>(List<SearchField> SearchFieldList) where T : class
        {
            ListGenerator list = new ListGenerator();
            return list.QueryListGenerator<T>(SearchFieldList, string.Empty, false, 0).ToList();
        }
    }
}
