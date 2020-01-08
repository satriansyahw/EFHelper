using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using EFHelper.ColumnHelper;
using EFHelper.Ekspression;

namespace EFHelper.Filtering
{
    public class WhereClause : InterfaceWhere
    {
        private static WhereClause instance;
        public WhereClause()
        {

        }
        public static WhereClause GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new WhereClause();
                return instance;
            }
        }
        public Expression<Func<T, bool>> GetWhereClause<T>(List<SearchField> SearchFieldList) 
        {
            ParameterExpression pe = Expression.Parameter(typeof(T), typeof(T).Name);
           var sss =Activator.CreateInstance<T>();
            Expression combinedExpr = null;
            Expression e1 = null;
            Expression columnNameExpr = null;
            Expression columnValueExpr = null;
            string fieldType = string.Empty;
            string fieldName = string.Empty;
            string fullName = string.Empty;
            string colName = string.Empty;
            string colOperator = string.Empty;
            object colValue = null;
            bool isNull = false;

            SearchFieldList.RemoveAll(a => a.Name == null);//clearingSearchFieldList
            foreach (SearchField itemSearch in SearchFieldList)
            {
                e1 = null;
                columnNameExpr = null;
                columnValueExpr = null;
                fieldType = string.Empty;
                fieldName = string.Empty;
                fullName = string.Empty;
                isNull = false;
                colName = itemSearch.Name;
                colOperator = itemSearch.Operator;              
                if(!string.IsNullOrEmpty(colName) & !string.IsNullOrEmpty(colOperator) & !string.IsNullOrEmpty(itemSearch.Value))
                {
                    colName = colName.Trim().ToLower();
                    colOperator = colOperator.Trim().ToLower();
                    colValue = itemSearch.Value.Trim().ToLower();

                    var colProp =ColumnPropGet.GetInstance.GetColumnProps(typeof(T),colName);
                    if (colProp != null)//Check if colname exists in Table
                    {
                        columnNameExpr = Expression.Property(pe, colName);                                          
                        fieldType = colProp.PropertyType.Name.ToLower();
                        fullName = colProp.PropertyType.FullName.ToLower().Split(',')[0].ToString();
                        fieldName = ColumnProperties.GetInstance.GetClearFieldName(colProp.Name);
                        isNull = ColumnProperties.GetInstance.IsNullableField(fieldType);
                        fieldType = ColumnProperties.GetInstance.ReplaceFieldSystemNullType(fullName);
                        string myOperator = fieldType == "datetime" ? "datetime" : colOperator;
                        e1 = ExpressionBantuan.GetInstance.DictOperatorExpr[myOperator].GetExpression(isNull, fieldType, colOperator, columnNameExpr, columnValueExpr);

                        if (e1 != null)
                        {
                            if (combinedExpr == null)
                            {
                                combinedExpr = e1;
                            }
                            else
                            {
                                combinedExpr = Expression.And(combinedExpr, e1);
                            }
                        }
                    }

                }
            }


            if (combinedExpr != null)
            {
                return Expression.Lambda<Func<T, Boolean>>(combinedExpr, new ParameterExpression[] { pe });
            }
            else
            {
                return null;
            }
        }
    }
}
