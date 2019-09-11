using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Value_Store
{
    struct KeyValue
    {
        public string Key { get; }
        public object Value { get; }

        public KeyValue(string key, object value)
        {
            Key = key;
            Value = value;

        }
    }
}
