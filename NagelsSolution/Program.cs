﻿namespace NagelsCodingProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string hexString =
                "A4 E6 16 76 56 C7 32 05 54 B2 04 C7 46 42 E2 E2 E2 E2 E2 E2 E3 9C 15 AF 43 " +
                "F4 26 17 47 46 C6 52 06 F6 62 04 86 17 37 46 96 E6 77 32 02 00 42 A0 5F 48 " +
                "04 16 C6 26 57 27 42 04 56 96 E7 37 46 56 96 E2 04 26 F7 26 E2 B6 74 E6 60 " +
                "C4 16 C6 16 E2 05 47 57 26 96 E6 72 04 56 E6 96 76 D6 12 02 00 8A E5 15 DA " +
                "94 36 86 57 26 E6 F6 27 96 C2 04 46 97 36 17 37 46 57 22 12 12 3A 35 7F 34";
            //string[] hexValues = hexString.Split(' ');

            bool bitA;
            bool bitC;
            bool bitB;
            bool bitD;
            string textA = String.Empty;
            short shortA = 0;
            DateTime dateTimeA = DateTime.MinValue;

            string hex1 = "A 4 E 6 1 6 7 6 5 6 C 7 3 2 0 5 5 4 B 2 0 4 C 7 4 6 4 2 E 2 E 2 E 2 E 2 E 2 E 2 E 3 9 C 1 5 A F 4 3";
            string[] hex1Values = hex1.Split(" ");
            var hexFormatted1 = FormatHex(hex1Values);
        }

        public static List<string> FormatHex(string[] hexValues)
        {
            List<string> formattedHexList = new List<string>();

            var tempHex1 = "";
            // set first hex for the bool representations --> reference - (4 bits per hex)
            for (int i = 0; i < 1; i++)
            {
                tempHex1 += hexValues[i];
            }

            var tempHex2 = "";
            // set second hex to string placeholder text --> 
            for (int i = 1; i <= 40; i++)
            {
                tempHex2 += hexValues[i];
            }

            var tempHex3 = "";
            // set third hex for short value -->
            for (int i = 41; i <= 44; i++)
            {
                tempHex3 += hexValues[i];
            }

            var tempHex4 = "";
            // set fourth hex for dateTime -->
            for (int i = 45; i <= hexValues.Length - 1; i++)
            {
                tempHex4 += hexValues[i];
            }

            // store split hex into list -->
            formattedHexList.Add(tempHex1);
            formattedHexList.Add(tempHex2);
            formattedHexList.Add(tempHex3);
            formattedHexList.Add(tempHex4);

            return formattedHexList;
        }
    }
}