using System;
using System.Collections.Generic;

namespace Key_Value_Store
{
    class MyDictionary
    {
        private KeyValue<object>[] keyvalues = new KeyValue<object>[]
        { new KeyValue<object>("key1", 1),
            new KeyValue<object>("key2", 2),
            new KeyValue<object>("key3", 3)};

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
                        keyvalues[i] = new KeyValue<object>(key, value);
                        break;
                    }
                    else
                    {
                        Array.Resize(ref keyvalues, length + 1);
                        keyvalues[length - 1] = new KeyValue<object>(key, value);
                    }
                }

            }
        }
    }
}
