using EFHelper.ColumnHelper;
using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace EFHelper.Ekspression
{
    public class EqualNotOperatorExpr : InterfaceOperatorExpr
    {

        public Expression GetExpression(bool isNull, string fieldType, string whereOperator, Expression columnNameExpr, Expression columnValueExpr)
        {
            Expression result = null;
            if (!string.IsNullOrEmpty(whereOperator) & columnNameExpr != null & columnValueExpr != null)
            {
                bool isInOperator = false;
                var type = TypeBantuan.GetInstance.DictTypes[fieldType].GetConvertedType(isNull, isInOperator);
                var myLeft = Expression.Convert(columnNameExpr, type);
                var myRight = Expression.Convert(columnValueExpr, type);
                result = Expression.NotEqual(myLeft, myRight);
            }
            return result;
        }

       
    }
}
