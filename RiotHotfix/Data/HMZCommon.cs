namespace RiotHotfix.Data
{
    public static class HMZCommon
    {
        static public object GetObj(this object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }
    }
}
