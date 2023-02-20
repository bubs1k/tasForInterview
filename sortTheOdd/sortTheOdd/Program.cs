/*Task
You will be given an array of numbers.
You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.

Examples
[7, 1]  =>  [1, 7]
[5, 8, 6, 3, 4]  =>  [3, 8, 6, 5, 4]
[9, 8, 7, 6, 5, 4, 3, 2, 1, 0]  =>  [1, 8, 3, 6, 5, 4, 7, 2, 9, 0]*/

public class Kata

{
    public static int[] SortArray(int[] array)
    {
        for (var first = 0; first < array.Length; first++)
        {
            for (var second = first; second < array.Length; second++)
            {
                if (array[first] % 2 == 1 && array[second] % 2 == 1 && array[first] > array[second])
                {
                    var temp = array[first];
                    array[first] = array[second];
                    array[second] = temp;
                }
            }
        }

        return array;
    }
}