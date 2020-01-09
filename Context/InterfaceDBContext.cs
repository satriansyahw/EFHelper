using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.Context
{
    public interface InterfaceDBContext
    {
        void CreateConnectionContext(DbContext dbContext)
        {

        }
    }
}
