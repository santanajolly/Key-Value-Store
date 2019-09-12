using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Value_Store
{
    class MyDictionary
    {
        KeyValue[] keyvalue = new KeyValue[] 
        { new KeyValue("key1", "value1"),
            new KeyValue("key2", "value2"),
            new KeyValue("key3", "value2")};

        

        private int numstored = keyvalue.Length;

        public object this[string key]
        {
            get
            {
                for (int i = 0; i < keyvalue.Length; i++)
                {
                    if (keyvalue[i].Key.ToLower() == key.ToLower())
                    {
                        return keyvalue[i].Value;
                        numstored += 1;
                    }
                }
                throw new KeyNotFoundException();
            }
            set
            {
                for (int i = 0; i < keyvalue.Length; i++)
                {
                    if (keyvalue[i].Key.ToLower() == key.ToLower())
                    {
                        keyvalue[i] = new KeyValue(key, value);
                    }
                }
                KeyValue[] temp = keyvalue;
            }
        }
    }     
}
