using EFHelper.ColumnHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.EntityPreparation
{
    public class EntityUpdate : InterfaceEntityPreparation
    {
        public T SetPreparationEntity<T>(T entity) where T : class
        {
            var propIdentity = ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
            if(propIdentity !=null)
            {
                object identityID = propIdentity.GetValue(entity);
                //List<SearchField> lsf = new List<SearchField>();
                //lsf.Add(new SearchField { Name = pi.Name, Operator = "=", Value1 = identityID.ToString() });
                //var THasil = await this.ListAsync<T>(lsf);
                //if (THasil != null & colNull != null & THasil.Count() > 0)
                //{
                //    var myHasil = THasil.ToList().SingleOrDefault();
                //    foreach (var itemNull in colNull)
                //    {
                //        var myValue = itemNull.GetValue(myHasil);
                //        GenHelperEF.Getinstance.SetColValue<T>(entity, itemNull.Name, myValue);
                //    }
                //}
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
