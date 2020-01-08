﻿using EFHelper.ColumnHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace EFHelper.TypeHelper
{
    public class TypeDouble : InterfaceType
    {
        public DbType GetConvertedDbType(string fieldType)
        {
            return DbType.Double;
        }

        public object GetDefaultValue(bool isNull)
        {
            object defaultValue = null;
                defaultValue =isNull ? (Nullable<double>)0: (double)0;
            return defaultValue;
        }
        public Type GetConvertedType(bool isNull, bool isInOperator)
        {
            Type t = null;
            if (isInOperator)
                t = isNull ? typeof(List<Nullable<double>>) : typeof(List<double>);
            else
                t = isNull ? typeof(Nullable<double>) : typeof(double);
            return t;
        }
        public MethodInfo GetInMethodInfo(bool isNull)
        {
            MethodInfo t = null;
            t = isNull ? t = typeof(List<double>).GetMethod("Contains", new[] { typeof(Nullable<double>) })
                : t = typeof(List<double>).GetMethod("Contains", new[] { typeof(double) });
            return t;
        }
        public object GetConvertedValue(bool isNull, object values, string whereOperator)
        {

            object result = null;
            string value = string.Empty;
            string myValue = string.Empty;
            if (values != null)
            {
                bool isInOperator = false;
                value = values.ToString();
                if (ColumnProperties.GetInstance.IsColumn(whereOperator.Trim().ToLower(), "in", "like","contains") || value.Contains("|"))
                    isInOperator = true;
                if (isInOperator)
                {
                    if (isNull)
                    {
                        var t = new List<Nullable<double>>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToDouble(myValue));
                        }
                        result = t;
                    }
                    else
                    {
                        var t = new List<double>();
                        foreach (var item in value.Split('|'))
                        {

                            myValue = item.Trim().ToLower();
                            t.Add(Convert.ToDouble(myValue));
                        }
                        result = t;
                    }

                }
                else
                {
                    var t = new double();
                    myValue = value.Trim().ToLower();
                    t = Convert.ToDouble(myValue);
                    result = t;
                }

            }
            return result;

        }
    }
}
