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
    public class EntityUpdateDefined : InterfaceEntityPreparation
    {
        public T SetPreparationEntity<T>(T entity) where T : class
        {
            TypeBantuan tipe = new TypeBantuan();
            var propUpdateDate = ColumnPropGet.GetInstance.GetColumnProps<T>("updatedate");
            propUpdateDate = propUpdateDate != null ? propUpdateDate : ColumnPropGet.GetInstance.GetColumnProps<T>("updatetime");
            if (propUpdateDate != null)
            {
                if (propUpdateDate.GetValue(entity) == null)
                {
                    object objUpdateDate = tipe.DictTypes[ColumnPropGet.GetInstance.GetColumnType(propUpdateDate)].GetDefaultValue(false);
                    propUpdateDate.SetValue(entity, objUpdateDate);
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
