using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EFHelper.MiscClass
{
    public class EFReturnValue<T> where T : class
    {
        public bool Result { get; set; }
        public T Entity { get; set; }
    }

}
