using EFHelper.Filtering;
using EFHelper.MiscClass;
using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
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
        public List<ConvertNoToNamePI> GetColumnConvertPI<T>(List<ColumnConvertNoToName> listColumnConvert) where T : class
        {
            var result = new List<ConvertNoToNamePI>();
            foreach (var item in listColumnConvert)
            {
                var sourcePI = ColumnPropGet.GetInstance.GetColumnProps<T>(item.SourceColumnNo);
                var targetPI = ColumnPropGet.GetInstance.GetColumnProps<T>(item.TargetColumnName);
                result.Add(new ConvertNoToNamePI { SourceNoPropertyInfo = sourcePI, TargetNamePropertyInfo = targetPI });
            }
            return result;
        }
        public List<T> GetInstanceWithIDColumnList<T>(List<int> listIDIdentity) where T : class
        {
            List<T> listEntity = new List<T>();
            foreach (var IDIdentity in listIDIdentity)
            {
                T entity = Activator.CreateInstance<T>();
                if (entity != null)
                {
                    ColumnPropSet.GetInstance.SetColValueIdentityColumn<T>(entity, IDIdentity);
                    listEntity.Add(entity);
                }
            }
            return listEntity;
        }
        public List<ColumnListInfo> GetColumnList(Type t) 
        {
            List<ColumnListInfo> list = new List<ColumnListInfo>();
            var entity = Activator.CreateInstance(t);
            foreach (var property in entity.GetType().GetRuntimeProperties())
            {
                string colName = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                list.Add(new ColumnListInfo { ColName = colName, ColPropInfo = property });
            }
            return list;
        }
        public List<ColumnListInfo> GetColumnList<T>() where T : class
        {
            List<ColumnListInfo> list = new List<ColumnListInfo>();
            T entity = (T)Activator.CreateInstance(typeof(T));
            foreach (var property in entity.GetType().GetRuntimeProperties())
            {
                string colName = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
                list.Add(new ColumnListInfo { ColName = colName, ColPropInfo = property });
            }
            return list;
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

                if (myFieldType == "datetime" & !ColumnProperties.GetInstance.IsColumn(myFieldName, MiscClass.MiscClass.ArrayInsertDate))
                {
                    result.Add(property);
                }
                if (myFieldType == "boolean" & !ColumnProperties.GetInstance.IsColumn(myFieldName, MiscClass.MiscClass.ArrayActiveBool))
                {
                    result.Add(property);
                }
            }
            return result;
        }
        public List<PropertyInfo> GetPropertyColNullOnly<T>(T entity) where T : class
        {

            string fullName = string.Empty;
            List<PropertyInfo> resultAwal = new List<PropertyInfo>();
            List<PropertyInfo> result = new List<PropertyInfo>();
            //looking from null value column
            resultAwal = (from sa in entity.GetType().GetProperties().AsQueryable() where sa.GetValue(entity) == null select sa).ToList();
            foreach (PropertyInfo property in resultAwal)
            {
                var sss = property.PropertyType.Name.ToLower();
                result.Add(property);
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

                if (!ColumnProperties.GetInstance.IsColumn(myFieldName, "activebool","boolactive", "insertby", "insertbyid"))
                {
                    result.Add(property);
                }
                if (myFieldType == "datetime" & ColumnProperties.GetInstance.IsColumn(myFieldName, MiscClass.MiscClass.ArrayUpdateDate))
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
        public PropertyInfo GetColumnProps<T>(params string[] colnames) where T : class
        {
            T entity = (T)Activator.CreateInstance(typeof(T));
            PropertyInfo pi = null;
            for (int i = 0; i < colnames.Count(); i++)
            {
                string colname = colnames[i].Trim().ToLower();
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
                if (pi != null)
                {

                    break;
                }
            }
          

            return pi;
        }
        public PropertyInfo GetColumnProps(Type t,params string[] colnames)
        {
            var entity = Activator.CreateInstance(t);
            PropertyInfo pi = null;
            for (int i = 0; i < colnames.Count(); i++)
            {
                string colname = colnames[i].Trim().ToLower();
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
                if (pi != null)
                {

                    break;
                }
            }


            return pi;
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
        public bool GetCheckIsDBCommandList<T>(List<SearchField> lsf) where T:class
        {
            //check if like
            bool result = false;
            string colName = string.Empty;
            string queryOperator = string.Empty;
            //like,datetime
            foreach (var item in lsf)
            {
                if (!string.IsNullOrEmpty(item.Name) & !string.IsNullOrEmpty(item.Operator) & item.Value != null)
                {
                    queryOperator = item.Name.ToLower().Trim();
                    if (queryOperator == "like")
                    {
                        result = true;
                        break;
                    }
                    else
                    {
                        colName = item.Name.ToString().ToLower().Trim().Replace(@"""", "").Replace("'", "");
                        var colProp = this.GetColumnProps<T>(colName);
                        if(colProp !=null)
                        {
                            string fullName = colProp.PropertyType.FullName.ToLower().Split(',')[0].ToString();
                            string myFieldType = colProp.PropertyType.Name.ToLower();
                            bool isnullData = myFieldType == ColumnProperties.GetInstance.NullAbleInfo ? true : false;
                            myFieldType = isnullData ? ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName) : myFieldType.ToLower().Trim();
                            if(myFieldType =="datetime")
                            {
                                result = true;
                                break;
                            }
                        }
                    }
                }


            }    
            return result;
        }
        public bool GetCheckIsDBCommandList(List<SearchField> lsf,Type t)
        {
            //check if like
            bool result = false;
            string colName = string.Empty;
            string queryOperator = string.Empty;
            //like,datetime
            foreach (var item in lsf)
            {
                if (!string.IsNullOrEmpty(item.Name) & !string.IsNullOrEmpty(item.Operator) & item.Value != null)
                {
                    queryOperator = item.Name.ToLower().Trim();
                    if (queryOperator == "like")
                    {
                        result = true;
                        break;
                    }
                    else
                    {
                        colName = item.Name.ToString().ToLower().Trim().Replace(@"""", "").Replace("'", "");
                        var colProp = this.GetColumnProps(t,colName);
                        if (colProp != null)
                        {
                            string fullName = colProp.PropertyType.FullName.ToLower().Split(',')[0].ToString();
                            string myFieldType = colProp.PropertyType.Name.ToLower();
                            bool isnullData = myFieldType == ColumnProperties.GetInstance.NullAbleInfo ? true : false;
                            myFieldType = isnullData ? ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName) : myFieldType.ToLower().Trim();
                            if (myFieldType == "datetime")
                            {
                                result = true;
                                break;
                            }
                        }
                    }
                }


            }
            return result;
        }
        public PropertyInfo GetIdentityColumnProps(Type t)
        {
            var entity = Activator.CreateInstance(t);
            PropertyInfo pi = null;
            foreach (PropertyInfo property in entity.GetType().GetRuntimeProperties())
            {
                var attributes = property.GetCustomAttributes(false).Where(a => a.GetType() == typeof(DatabaseGeneratedAttribute));
                foreach (var attribute in attributes)
                {
                    if (((DatabaseGeneratedAttribute)attribute).DatabaseGeneratedOption.ToString().ToLower() == "identity")
                    {
                        pi = property;
                        break;
                    }
                }

                if (pi != null)
                    break;               
            }
            pi = pi != null ? pi : entity.GetType().GetRuntimeProperties().ToList()[0];// jika null ambil property yang ke 0
            return pi;
        }
        public PropertyInfo GetIdentityColumnProps<T>() where T : class
        {
            T entity = (T)Activator.CreateInstance(typeof(T));
            PropertyInfo pi = null;
            foreach (PropertyInfo property in entity.GetType().GetRuntimeProperties())
            {
                var attributes = property.GetCustomAttributes(false).Where(a => a.GetType() == typeof(DatabaseGeneratedAttribute));
                foreach (var attribute in attributes)
                {
                    if (((DatabaseGeneratedAttribute)attribute).DatabaseGeneratedOption.ToString().ToLower() == "identity")
                    {
                        pi = property;
                        break;
                    }
                }

                if (pi != null)
                    break;
            }
            pi = pi != null ? pi : entity.GetType().GetRuntimeProperties().ToList()[0];// jika null ambil property yang ke 0
            return pi;
        }
        public string GetColumnType(PropertyInfo property)
        {
            string fullName = property.PropertyType.FullName.ToLower().Split(',')[0].ToString();
            string myFieldName = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
            string myFieldType = property.PropertyType.Name.ToLower();
            bool isnullData = myFieldType == ColumnProperties.GetInstance.NullAbleInfo ? true : false;
            myFieldType = isnullData ? ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName) : myFieldType;
            return myFieldType;
        }
        public string GetColumnDBType(PropertyInfo property)
        {
            string fullName = property.PropertyType.FullName.ToLower().Split(',')[0].ToString();
            string myFieldName = ColumnProperties.GetInstance.GetClearFieldName(property.Name);
            string myFieldType = property.PropertyType.Name.ToLower();
            bool isnullData = myFieldType == ColumnProperties.GetInstance.NullAbleInfo ? true : false;
            myFieldType = isnullData ? ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName) : myFieldType;
            return myFieldType;
        }
        public Expression<Func<TSource, TResult>> GetSelectedColumnExpression<TSource, TResult>() where TSource : class where TResult : class
        {
            Expression<Func<TSource, TResult>> result = null;
             string itemlist = string.Empty;
            string itemcheck = string.Empty;
            var sourceType = typeof(TSource);
            var resultType = typeof(TResult);
            var listColSource = this.GetColumnList(typeof(TSource));
            var listColResult = this.GetColumnList(typeof(TResult));
            var listMemberInfo = (from a in listColResult
                                  join b in listColSource on a.ColName equals b.ColName
                                  select (MemberInfo)b.ColPropInfo);// mencari member info dari TResult                   

            if (listMemberInfo != null)
            {
                var parameter = Expression.Parameter(sourceType, "e");
                var bindings = listMemberInfo.Select(member => Expression.Bind(
                    resultType.GetProperty(member.Name), Expression.MakeMemberAccess(parameter, member)));
                var body = Expression.MemberInit(Expression.New(resultType), bindings);
                result = Expression.Lambda<Func<TSource, TResult>>(body, parameter);
            }
            return result;

        }
        public Expression GetSelectedColumnExpression(Type tSource,Type tResult) 
        {
            Expression result = null;
            string itemlist = string.Empty;
            string itemcheck = string.Empty;
            var sourceType = tSource;
            var resultType = tResult;
            var listColSource = this.GetColumnList(tSource);
            var listColResult = this.GetColumnList(tResult);
            var listMemberInfo = (from a in listColResult
                                  join b in listColSource on a.ColName equals b.ColName
                                  select (MemberInfo)b.ColPropInfo);// mencari member info dari TResult                   

            if (listMemberInfo != null)
            {
                var parameter = Expression.Parameter(sourceType, "e");
                var bindings = listMemberInfo.Select(member => Expression.Bind(
                    resultType.GetProperty(member.Name), Expression.MakeMemberAccess(parameter, member)));
                var body = Expression.MemberInit(Expression.New(resultType), bindings);
                result = Expression.Lambda(body, parameter);
            }
            return result;

        }
    }
}
