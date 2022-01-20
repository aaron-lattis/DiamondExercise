using System;

public static class Diamond
{
    public static string Make(char target)
    {
        string result = "";

        int ASCII = Convert.ToInt32(target);

        int lettersPosition = ASCII - 64;

        int highCntr = lettersPosition;
        int lowCntr = lettersPosition;

        int letterCntr = 65;


        for (int i = 0; i < lettersPosition; i++)
        {
            for (int j = 1; j < lettersPosition * 2; j++)
            {
                result += Helper.PlaceLetters(j: j, highCntr: highCntr, lowCntr: lowCntr, letterCntr: letterCntr);
            }

            Helper.SetCounters(ref letterCntr, ref highCntr, ref lowCntr, top: true);

            result += "\n";
        }

        Helper.SetCounters(ref letterCntr, ref highCntr, ref lowCntr, top: false);
        Helper.SetCounters(ref letterCntr, ref highCntr, ref lowCntr, top: false);

        for (int i = 0; i < lettersPosition - 1; i++)
        {
            for (int j = lettersPosition * 2 - 1; j > 0; j--)
            {
                result += Helper.PlaceLetters(j: j, highCntr: highCntr, lowCntr: lowCntr, letterCntr: letterCntr);
            }

            Helper.SetCounters(ref letterCntr, ref highCntr, ref lowCntr, top: false);

            result += "\n";
        }

        return result;
    }
}