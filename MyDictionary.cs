using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Value_Store
{
    class MyDictionary
    {
        KeyValue[] keyvalues = new KeyValue[] 
        { new KeyValue("key1", 1),
            new KeyValue("key2", 2),
            new KeyValue("key3", 3)};

        

        private int length
        {
            get { return this.keyvalues.Length; }
        }

        public object this[string key]
        {
            get
            {
                for (int i = 0; i < keyvalues.Length; i++)
                {
                    if (keyvalues[i].Key.ToLower() == key.ToLower())
                    {
                        return keyvalues[i].Value;
                    }
                }
                throw new KeyNotFoundException();
            }
            set
            {
                for (int i = 0; i < keyvalues.Length; i++)
                {
                    if (keyvalues[i].Key.ToLower() == key.ToLower())
                    {
                        keyvalues[i] = new KeyValue(key, value);
                        break;
                    }
                    else
                    {
                        Array.Resize(ref keyvalues, length + 1);
                        keyvalues[length - 1] = new KeyValue(key, value);
                    }
                }
                
            }
        }
    }     
}
