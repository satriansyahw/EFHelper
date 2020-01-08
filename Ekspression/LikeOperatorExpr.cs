using EFHelper.ColumnHelper;
using EFHelper.TypeHelper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EFHelper.Ekspression
{
    public class LikeOperatorExpr : InterfaceOperatorExpr
    {

        public Expression GetExpression(bool isNull,string fieldType, string whereOperator,Expression columnNameExpr, Expression columnValueExpr)
        {
            Expression result = null;
            if (!string.IsNullOrEmpty(whereOperator) & columnNameExpr != null & columnValueExpr != null)
            {
                bool isInOperator = false;
                var type = TypeBantuan.GetInstance.DictTypes["string"].GetConvertedType(isNull, isInOperator);
                var method = TypeBantuan.GetInstance.DictTypes["string"].GetInMethodInfo(isNull);
                var myLeft = Expression.Convert(columnValueExpr, type);
                result= Expression.Call(myLeft, method, columnNameExpr);
            }
            return result;
        }
    }
}
