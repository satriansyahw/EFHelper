﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EFHelper.Context
{
    public class DBContextBantuan : InterfaceDBContext
    {
        private static DBContextBantuan instance;
        public DBContextBantuan(DbContext dbContext)
        {
            DBContextInfo.MyDbContext= dbContext;
        }
        public DBContextBantuan()
        {
        }
        public DbContext CreateConnectionContext()
        {
            DbContext mydbContext = DBContextInfo.MyDbContext;
            //mydbContextBridge.Database.Initialize(force: false);
            var entity = Activator.CreateInstance(mydbContext.GetType());
            mydbContext = (DbContext)entity;
            mydbContext.ChangeTracker.AutoDetectChangesEnabled = false;
            mydbContext.ChangeTracker.LazyLoadingEnabled = false;
            return mydbContext;
        }
        public static DBContextBantuan GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new DBContextBantuan();
                return instance;
            }
        }
    }
}
