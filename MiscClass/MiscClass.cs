using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EFHelper.MiscClass
{
    public class MiscClass
    {
        public enum EnumSaveUpdateDelete
        {
            Save,Update,Delete
        }
        public static string[] ArrayInsertDate = { "insertdate", "inserttime" };
        public static string[] ArrayUpdateDate = { "updatedate","updatetime" };
        public static string[] ArrayActiveBool = { "activebool", "boolactive" };
        public static int CommandTimeOut =100;
    }
    public class ColumnConvertNoToName
    {
        public string SourceColumnNo { get; set; }
        public string TargetColumnName { get; set; }
    }
    public class ConvertNoToName
    {
        public string ColumnNoValue { get; set; }
        public string ColumnNameValue { get; set; }
    }
    public class ConvertNoToNamePI
    {
        public PropertyInfo SourceNoPropertyInfo { get; set; }
        public PropertyInfo TargetNamePropertyInfo { get; set; }
    }

}
