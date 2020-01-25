using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EFHelper.MiscClass
{
    public class EFReturnValue
    {
        public bool IsSuccessConnection { get; set; }
        public bool IsSuccessQuery { get; set; }
        public string ErrorMessage { get; set; }
        public dynamic ReturnValue { get; set; }

        public EFReturnValue SetEFReturnValue(EFReturnValue eFReturn, bool IsSuccessConnection, int hasilSaveChanges, params object[] objectResult)
        {

            if (IsSuccessConnection)
            {
                eFReturn.IsSuccessConnection = true;
                if (hasilSaveChanges > 0)
                {
                    eFReturn.IsSuccessQuery = true;
                    eFReturn.ErrorMessage = string.Empty;
                    List<DictReturnValue> dictReturn = new List<DictReturnValue>();
                    foreach (var item in objectResult)
                    {
                        dictReturn.Add(new DictReturnValue { Name = item.GetType().Name.Replace("`",""), ReturnValue = item });
                    }
                    eFReturn.ReturnValue = dictReturn;
                }
                else
                {
                    eFReturn.IsSuccessQuery = false;
                    eFReturn.ErrorMessage = objectResult.ToString();
                    eFReturn.ReturnValue = null;
                }

            }
            return eFReturn;
        }
        public class DictReturnValue
        {
            public string Name { get; set; }
            public object ReturnValue { get; set; }
        }

    }
}
