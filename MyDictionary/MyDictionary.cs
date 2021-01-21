using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public TKey[] Keys { get { return keys; } }
        public TValue[] Values { get { return values; } }

        public void Add(TKey key, TValue value)
        {
            // if the key already exists in the keys array
            // throw an argument exception
            if (Array.IndexOf(keys, key) > -1)
            {
                throw new ArgumentException();
            }
            else
            {

                TKey[] tempKeys = keys;
                TValue[] tempValues = values;
                keys = new TKey[keys.Length + 1];
                values = new TValue[values.Length + 1];

                for (int i = 0; i < tempKeys.Length; i++)

                {
                    keys[i] = tempKeys[i];
                    values[i] = tempValues[i];
                }

                keys[keys.Length - 1] = key;
                values[values.Length - 1] = value;
            }
        }

        public bool ContainsKey(TKey key)
        {
            return Array.IndexOf(keys,key) > -1;
        }
    }
}
