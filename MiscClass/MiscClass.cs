using System;
using System.Collections.Generic;
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
}
