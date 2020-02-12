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
