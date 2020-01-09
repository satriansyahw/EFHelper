using EFHelper.ColumnHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.EntityPreparation
{
    public class EntitySave : InterfaceEntityPreparation
    {
        public T SetPreparationEntity<T>(T entity) where T : class
        {
            var propIdentity = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
            if(propIdentity !=null)
            {
                propIdentity.SetValue(entity, 0);
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
