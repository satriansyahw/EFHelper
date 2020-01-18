﻿using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EFHelper.ColumnHelper
{
    public class ColumnPropSet
    {
        private static ColumnPropSet instance;
       
        public ColumnPropSet()
        {
            
        }
        public static ColumnPropSet GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new ColumnPropSet();
                return instance;
            }
        }
       
        public T SetPropertyColDefaultValue<T>(T entity) where T : class
        {
            List<PropertyInfo> listNull = new List<PropertyInfo>();
            listNull = ColumnPropGet.GetInstance.GetPropertyColNull<T>(entity);
            string fullName = string.Empty;
            object defaultValue = null;
            bool isnullData = false;
            foreach (PropertyInfo property in listNull)
            {
                fullName = property.PropertyType.FullName.ToLower().Split(',')[0].ToString();
                string myFieldName = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                string myFieldType = property.PropertyType.Name.ToLower();
                isnullData = myFieldType == ColumnProperties.GetInstance.NullAbleInfo ? true : false;
                myFieldType = isnullData ? ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName) : myFieldType;
                defaultValue = TypeBantuan.GetInstance.DictTypes[myFieldType].GetDefaultValue(isnullData);
                SetColValue<T>(entity, property.Name, defaultValue);
            }
            return entity;
        }
        public T SetColValue<T>(T entity, string colName, object value) where T : class
        {
            PropertyInfo pi = ColumnPropGet.GetInstance.GetColumnProps<T>(colName.ToLower());
            if (pi != null)
            {
                if (pi.CanWrite)
                {
                    
                    pi.SetValue(entity, value);

                }
            }
            return entity;
        }
        public T SetColValueIdentityColumn<T>(T entity, object value) where T : class
        {
            string idcolname = string.Empty;
            PropertyInfo pi= ColumnPropGet.GetInstance.GetIdentityColumnProps<T>();
            
            if (pi != null)
            {
                if (pi.CanWrite)
                {

                    pi.SetValue(entity, value);

                }
            }
            return entity;
        }
    }
}
