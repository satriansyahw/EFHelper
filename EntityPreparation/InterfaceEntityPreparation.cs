using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.EntityPreparation
{
    public interface InterfaceEntityPreparation
    {
        T SetPreparationEntity<T>(T entity) where T : class;
        List<T> SetPreparationEntity<T>(List<T> listEntity) where T : class;
       


    }
}
