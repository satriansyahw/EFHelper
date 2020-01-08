using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EFHelper.ColumnHelper
{
    public class ColumnPropGet
    {
        private static ColumnPropGet instance;

        public ColumnPropGet()
        {

        }
        public static ColumnPropGet GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new ColumnPropGet();
                return instance;
            }
        }
        public List<PropertyInfo> GetPropertyColNull<T>(T entity) where T : class
        {

            string fullName = string.Empty;
            List<PropertyInfo> resultAwal = new List<PropertyInfo>();
            List<PropertyInfo> result = new List<PropertyInfo>();
            //looking from null value column
            resultAwal = (from sa in entity.GetType().GetProperties().AsQueryable() where sa.GetValue(entity) == null select sa).ToList();
            foreach (PropertyInfo property in resultAwal)
            {
                var sss  =property.PropertyType.Name.ToLower();
                result.Add(property);
            }
            //looking from not value column
            resultAwal = (from sa in entity.GetType().GetProperties().AsQueryable() where sa.GetValue(entity) != null select sa).ToList();
            foreach (PropertyInfo property in resultAwal)
            {
                fullName = property.PropertyType.FullName.ToLower().Split(',')[0].ToString();
                string myFieldName = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                string myFieldType = property.PropertyType.Name.ToLower();
                myFieldType = myFieldType == ColumnProperties.GetInstance.NullAbleInfo ? ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName) : myFieldType;

                if (myFieldType == "datetime" & !ColumnProperties.GetInstance.IsColumn(myFieldName, "insertdate", "inserttime"))
                {
                    result.Add(property);
                }
                if (myFieldType == "boolean" & !ColumnProperties.GetInstance.IsColumn(myFieldName, "activebool", "boolactive"))
                {
                    result.Add(property);
                }
            }
            return result;
        }
        public List<PropertyInfo> GetPropertyColNotNull<T>(T entity) where T : class
        {
            string fullName = string.Empty;
            List<PropertyInfo> resultAwal = new List<PropertyInfo>();
            List<PropertyInfo> result = new List<PropertyInfo>();
            resultAwal = (from sa in entity.GetType().GetProperties().AsQueryable() where sa.GetValue(entity) != null select sa).ToList();
            foreach (PropertyInfo property in resultAwal)
            {
                fullName = property.PropertyType.FullName.ToLower().Split(',')[0].ToString();
                string myFieldName = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                string myFieldType = property.PropertyType.Name.ToLower();
                myFieldType = myFieldType == ColumnProperties.GetInstance.NullAbleInfo ? ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName) : myFieldType;

                if (myFieldType != "datetime" & !ColumnProperties.GetInstance.IsColumn(myFieldName, "activebool", "boolactive", "insertby", "insertbyid"))
                {
                    result.Add(property);
                }
                if (myFieldType == "datetime" & ColumnProperties.GetInstance.IsColumn(myFieldName, "updatedate", "updatetime"))
                {
                    if (property.CanWrite)
                    {
                        property.SetValue(entity, (object)DateTime.Now);
                    }
                    result.Add(property);

                }
            }
            return result;
        }
        public PropertyInfo GetColumnProps<T>(string colname) where T : class
        {
            T entity = (T)Activator.CreateInstance(typeof(T));
            PropertyInfo pi = null;
            colname = colname.Trim().ToLower();
            string myProp = string.Empty;
            foreach (var property in entity.GetType().GetRuntimeProperties())
            {
                if (!string.IsNullOrEmpty(property.Name))
                {
                    colname = ColumnProperties.GetInstance.GetClearFieldName(colname);
                    myProp = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                    if (myProp == colname.Trim())
                    {
                        pi = property;
                    }
                }
                if (pi != null)
                {

                    break;
                }

            }

            return pi;
        }
        public PropertyInfo GetColumnProps(Type t, string colname)
        {
            var entity = Activator.CreateInstance(t);
            PropertyInfo pi = null;
            colname = colname.Trim().ToLower();
            string myProp = string.Empty;
            foreach (var property in entity.GetType().GetRuntimeProperties())
            {
                if (!string.IsNullOrEmpty(property.Name))
                {
                    colname = ColumnProperties.GetInstance.GetClearFieldName(colname);
                    myProp = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                    if (myProp == colname.Trim())
                    {
                        pi = property;
                    }
                }
                if (pi != null)
                {

                    break;
                }

            }

            return pi;
        }

    }
}
