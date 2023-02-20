/*Find the sum of the odd numbers within an array, after cubing the initial integers. 
The function should return undefined/None/nil/NULL if any of the values aren't numbers.

Note: There are ONLY integers in the JAVA and C# versions of this Kata.*/

public class Kata
{
    public static int CubeOdd(int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0) /*if the number is not divisible by 2.that is, if the number is odd...*/
            {
                sum = sum + (arr[i] * arr[i] * arr[i]); /*...we put the cube of this number in the variable sum*/
            }
        }

        return sum;
    }
}