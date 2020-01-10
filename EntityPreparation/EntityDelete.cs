using EFHelper.ColumnHelper;
using EFHelper.Filtering;
using EFHelper.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using EFHelper.TypeHelper;

namespace EFHelper.EntityPreparation
{
    public class EntityDelete : InterfaceEntityPreparation
    {
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
                    var colNull = ColumnPropGet.GetInstance.GetPropertyColNull<T>(entity);
                    var checkEntity = checkEntityList.ToList()[0];
                    foreach (PropertyInfo itemPropUpdate in colNull)
                    {
                        // update tblEntity
                        var itemPropUpdateValue = itemPropUpdate.GetValue(checkEntity);
                        ColumnPropSet.GetInstance.SetColValue<T>(entity, itemPropUpdate.Name, itemPropUpdateValue);
                    }
                    TypeBantuan tipe = new TypeBantuan();
                    var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate");
                    propUpdateDate = propUpdateDate != null ? propUpdateDate : ColumnPropGet.GetInstance.GetColumnProps<T>("updatetime");
                    var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool");
                    propActiveBool = propActiveBool != null ? propActiveBool : ColumnPropGet.GetInstance.GetColumnProps<T>("boolactive");
                    if (propUpdateDate != null)
                    {
                        if (propUpdateDate.GetValue(entity) == null)
                        {
                            object objUpdateDate = tipe.DictTypes[ColumnPropGet.GetInstance.GetColumnType(propUpdateDate)].GetDefaultValue(false);
                            propUpdateDate.SetValue(entity, objUpdateDate);
                        }
                    }
                    if (propActiveBool != null)
                    {
                        if (propActiveBool.GetValue(entity) == null)
                        {
                            propActiveBool.SetValue(entity, false);
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
