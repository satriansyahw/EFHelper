using EFHelper.ColumnHelper;

using System.Collections.Generic;

using EFHelper.TypeHelper;
using EFHelper.RepositoryList;
using EFHelper.Filtering;
using System.Reflection;

namespace EFHelper.EntityPreparation
{
    public class EntityUpdateDefined : InterfaceEntityPreparation
    {
        public T SetPreparationEntity<T>(T entity) where T : class
        {
            //update all all field defined in entity ,additonal if forget for updatedate
            TypeBantuan tipe = new TypeBantuan();
            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);
            if (propUpdateDate != null)
            {
                if (propUpdateDate.CanWrite)
                {
                    object objUpdateDate = tipe.DictTypes[ColumnPropGet.GetInstance.GetColumnType(propUpdateDate)].GetDefaultValue(false);
                    propUpdateDate.SetValue(entity, objUpdateDate);
                }
            }
            return entity;
            //var propIdentity = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
            //RepoList repo = new RepoList();
            //if (propIdentity != null)
            //{
            //    object identityID = propIdentity.GetValue(entity);
            //    List<SearchField> lsf = new List<SearchField>();
            //    lsf.Add(new SearchField { Name = propIdentity.Name, Operator = "=", Value = identityID.ToString() });
            //    var checkEntityList = repo.ListData<T>(lsf);
            //    var checkEntityListData = (List<T>)checkEntityList.ReturnValue[0].ReturnValue;
            //    if (checkEntityList != null & checkEntityList.IsSuccessConnection & checkEntityList.IsSuccessQuery
            //        & (checkEntityListData).Count > 0)
            //    {
            //        var colNull = ColumnPropGet.GetInstance.GetPropertyColNullOnly<T>(entity);
            //        var checkEntity = checkEntityListData[0];
            //        foreach (PropertyInfo itemPropUpdate in colNull)
            //        {
            //            // update tblEntity
            //            var itemPropUpdateValue = itemPropUpdate.GetValue(checkEntity);
            //            ColumnPropSet.GetInstance.SetColValue<T>(entity, itemPropUpdate.Name, itemPropUpdateValue);
            //        }
            //        TypeBantuan tipe = new TypeBantuan();
            //        var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>(MiscClass.MiscClass.ArrayUpdateDate);
            //        if (propUpdateDate != null)
            //        {
            //            if (propUpdateDate.CanWrite)
            //            {
            //                object objUpdateDate = tipe.DictTypes[ColumnPropGet.GetInstance.GetColumnType(propUpdateDate)].GetDefaultValue(false);
            //                propUpdateDate.SetValue(entity, objUpdateDate);
            //            }
            //        }

            //    }

            //}
            //return entity;
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
