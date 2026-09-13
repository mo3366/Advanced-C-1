using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_C__1.generic_class
{
    internal class Pair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public Pair(TKey _key, TValue _value)
        {
            Key = _key;
            Value = _value;
        }

        public override string ToString() => $"[{Key}, {Value}]";
    }
}
