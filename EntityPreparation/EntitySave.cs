using EFHelper.ColumnHelper;
using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.EntityPreparation
{
    public class EntitySave : InterfaceEntityPreparation
    {
        public T SetPreparationEntity<T>(T entity) where T : class
        {
            TypeBantuan tipe = new TypeBantuan();
            var propIdentity = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
            var propActiveBool = ColumnPropGet.GetInstance.GetColumnProps<T>("activebool","boolactive");
            var propInsertDate = ColumnPropGet.GetInstance.GetColumnProps<T>("insertdate","insertime");
            
            if (propIdentity !=null)
            {
                if (propIdentity.GetValue(entity) == null)
                {
                    object objID = tipe.DictTypes[ColumnPropGet.GetInstance.GetColumnType(propIdentity)].GetDefaultValue(false);
                    propIdentity.SetValue(entity, objID);
                }
            }
            if (propActiveBool != null)
            {
                if (propActiveBool.GetValue(entity) == null)
                {
                    object objActiveBool = tipe.DictTypes[ColumnPropGet.GetInstance.GetColumnType(propActiveBool)].GetDefaultValue(false);
                    propActiveBool.SetValue(entity, objActiveBool);
                }
            }
            if (propInsertDate != null)
            {
                if (propInsertDate.GetValue(entity) == null)
                {
                    object objInsertDate = tipe.DictTypes[ColumnPropGet.GetInstance.GetColumnType(propInsertDate)].GetDefaultValue(false);
                    propInsertDate.SetValue(entity, objInsertDate);
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
