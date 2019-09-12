using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Value_Store
{
    struct KeyValue
    {
        public readonly string Key;
        //use readonly, you don't need to use {get;}
        public readonly object Value;

        public KeyValue(string key, object value)
        {
            Key = key;
            Value = value;

        }
       


    }
    
            

                
}
