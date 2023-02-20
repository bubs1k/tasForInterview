/*Welcome.In this kata, you are asked to square every digit of a number and concatenate them.

For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1. (81-1-1-81)

Example #2: An input of 765 will/should return 493625 because 72 is 49, 62 is 36, and 52 is 25. (49-36-35)

Note: The function accepts an integer and returns an integer.

Happy Coding!*/

using System;
using System.Xml.Linq;

public class Kata
{
    public static int SquareDigits(int n)
    {
        string temp = "";

        int result = 0;

        string nToString = Convert.ToString(n);

        int[] array = new int[nToString.Length];


        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(nToString[i].ToString());/*place value nToString in array*/

            array[i] = array[i] * array[i];/*squaring each element of the array*/

            temp += array[i].ToString();
        }

        result = Convert.ToInt32(temp);

        return result;
    }
}