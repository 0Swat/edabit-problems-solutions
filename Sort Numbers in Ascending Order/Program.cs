using System.Linq;
public class Program
    {
        public static int[] SortNumsAscending(int[] arr)
        {
            if (arr == null || arr.Length == 0) return new int[0];
            return arr.OrderBy(x => x).ToArray();
        }
    }