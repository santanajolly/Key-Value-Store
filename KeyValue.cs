namespace Key_Value_Store
{
    public struct KeyValue<T>
    {
        public readonly string Key;
        //use readonly, you don't need to use {get;}
        public readonly T Value;

        public KeyValue(string key, T value)
        {
            Key = key;
            Value = value;
        }
    }
}
