using System.Collections.Generic;
using System.Linq;
using Infrastructure_Beter.Services.StaticServices;

namespace Infrastructure_Beter
{
    public static class Extensions
    {
        public static int[] ReturnUniqueArrayNumbers(this int[] result, int[] array)
        {
            List<int> values = new List<int>();
            FullUniqueNumbers(array, values);
            result = ListToArrayConverter.ConvertListToArray(values);
            return result;
        }

        public static int ReturnSizeUniqueNumbers(this int result, int[] array)
        {
            List<int> values = new List<int>();

            FullUniqueNumbers(array, values);

            result = values.Count;

            return result;
        }
        
        private static void FullUniqueNumbers(int[] numbers, List<int> values)
        {
            //TODO - ещё пример, где LINQ упростил решение задачи
            int[] distinct = numbers.Distinct().ToArray();
            for (int i = 0; i < distinct.Length; i++)
            {
                values.Add(distinct[i]);
            }
        }
        
        
    }
}