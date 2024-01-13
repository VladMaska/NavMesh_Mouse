using System.Collections.Generic;

namespace Infrastructure_Beter.Services.StaticServices
{
    public static class ListToArrayConverter
    {
        public static int[] ConvertListToArray(List<int> values)
        {
            int[] tempData = new int[values.Count];
            for (int i = 0; i < values.Count; i++)
            {
                tempData[i] = values[i];
            }
            return tempData;
        }
    }
}