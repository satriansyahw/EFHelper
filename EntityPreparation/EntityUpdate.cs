using EFHelper.ColumnHelper;

using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using EFHelper.TypeHelper;
using EFHelper.Filtering;
using EFHelper.RepositoryList;
namespace EFHelper.EntityPreparation
{
    public class EntityUpdate : InterfaceEntityPreparation
    {
        //update all all field,If forget update data entity, so auto fill from db record 
        public T SetPreparationEntity<T>(T entity) where T : class
        {
            var propIdentity = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
            RepoList repo = new RepoList();
            if (propIdentity !=null)
            {
                object identityID = propIdentity.GetValue(entity);
                List<SearchField> lsf = new List<SearchField>();
                lsf.Add(new SearchField { Name = propIdentity.Name, Operator = "=", Value = identityID.ToString() });
                var checkEntityList = repo.ListData<T>(lsf);
                if(checkEntityList != null & checkEntityList.Count() > 0)
                {
                    var colNull = ColumnPropGet.GetInstance.GetPropertyColNullOnly<T>(entity);
                    var checkEntity = checkEntityList.ToList()[0];
                    foreach (PropertyInfo itemPropUpdate in colNull)
                    {
                        // update tblEntity
                        var itemPropUpdateValue = itemPropUpdate.GetValue(checkEntity);
                        ColumnPropSet.GetInstance.SetColValue<T>(entity, itemPropUpdate.Name, itemPropUpdateValue);
                    }
                    TypeBantuan tipe = new TypeBantuan();
                    var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate","updatetime");
                    if (propUpdateDate != null)
                    {
                        if (propUpdateDate.GetValue(entity) == null)
                        {
                            object objUpdateDate = tipe.DictTypes[ColumnPropGet.GetInstance.GetColumnType(propUpdateDate)].GetDefaultValue(false);
                            propUpdateDate.SetValue(entity, objUpdateDate);
                        }
                    }

                }

            }
            return entity;
        }

        public List<T> SetPreparationEntity<T>(List<T> listEntity) where T : class
        {
            if(listEntity !=null)
            {
                for (int i = 0; i < listEntity.Count; i++)
                {
                    listEntity[i] = this.SetPreparationEntity<T>(listEntity[i]);
                }
            }
            return listEntity;
        }
    }
}
