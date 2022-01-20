using System;
using System.Collections.Generic;
using System.Text;


class Helper
{

    public static string PlaceLetters(int j, int highCntr, int lowCntr, int letterCntr)
    {
        string result = "";

        if (j == highCntr || j == lowCntr)
        {
            result += ((char)letterCntr).ToString();
        }
        else
        {
            result += ".";
        }

        return result;
    }

    public static void SetCounters(ref int letterCntr, ref int highCntr, ref int lowCntr, bool top)
    {
        int increment;

        if (top)
            increment = 1;
        else
            increment = -1;

        
        letterCntr += increment;

        highCntr += increment;

        lowCntr -= increment;
    }
}

