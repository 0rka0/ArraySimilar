using System;
using System.Linq;

namespace ArraySimilar
{
    /*
    Schreibe eine Funktion, mit der überprüft werden kann, ob 2 Arrays Ähnlichkeiten zueinander haben.
    Ähnlichkeit bedeutet, dass beide Arrays die selben Elemente beinhalten und dass diese Elemente in beiden Arrays gleich oft vorkommen.

    array1 = [1, 2, 2, 3, 4],
    array2 = [2, 1, 2, 4, 3],
    array3 = [1, 2, 3, 4],
    array4 = [1, 2, 3, "4"]

    ArraysSimilar(array1, array2); // Should equal true
    ArraysSimilar(array2, array3); // Should equal false
    ArraysSimilar(array3, array4); // Should equal false
    */

    public static class ArraysSimilarQuiz
    {
        public static bool ArraysSimilar(object[] array1, object[] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            array1 = array1.OrderBy(x => x.ToString()).ToArray();
            array2 = array2.OrderBy(x => x.ToString()).ToArray();

            for (int i = 0; i < array1.Length; i++)
            {
                if (!array1.GetValue(i).Equals(array2.GetValue(i)))
                    return false;
            }
            return true;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            var array1 = new object[] { 1, 2, 2, 3, 4 };
            var array2 = new object[] { 2, 1, 2, 4, 3 };
            var array3 = new object[] { 1, 2, 3, 4 };
            var array4 = new object[] { 1, 2, 3, "4" };

            if (ArraysSimilarQuiz.ArraysSimilar(array1, array2))
            {
                Console.WriteLine($"array1 [{string.Join(", ", array1)}] is similar to array2 [{string.Join(", ", array2)}]");
            }

            if (!ArraysSimilarQuiz.ArraysSimilar(array2, array3))
            {
                Console.WriteLine($"array2 [{string.Join(", ", array2)}] is NOT similar to array3 [{string.Join(", ", array3)}]");
            }

            if (!ArraysSimilarQuiz.ArraysSimilar(array3, array4))
            {
                Console.WriteLine($"array3 [{string.Join(", ", array3)}] is NOT similar to array4 [{string.Join(", ", array4)}]");
            }
        }
    }
}
