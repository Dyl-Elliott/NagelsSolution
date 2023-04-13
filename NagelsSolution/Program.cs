using System.Collections;
using System.Text;

namespace NagelsCodingProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string hexString =
            //    "A4 E6 16 76 56 C7 32 05 54 B2 04 C7 46 42 E2 E2 E2 E2 E2 E2 E3 9C 15 AF 43 " +
            //    "F4 26 17 47 46 C6 52 06 F6 62 04 86 17 37 46 96 E6 77 32 02 00 42 A0 5F 48 " +
            //    "04 16 C6 26 57 27 42 04 56 96 E7 37 46 56 96 E2 04 26 F7 26 E2 B6 74 E6 60 " +
            //    "C4 16 C6 16 E2 05 47 57 26 96 E6 72 04 56 E6 96 76 D6 12 02 00 8A E5 15 DA " +
            //    "94 36 86 57 26 E6 F6 27 96 C2 04 46 97 36 17 37 46 57 22 12 12 3A 35 7F 34";
            //string[] hexValues = hexString.Split(' ');

            bool bitA;
            bool bitC;
            bool bitB;
            bool bitD;
            string textA = String.Empty;
            short shortA = 0;
            DateTime dateTimeA = DateTime.MinValue;

            Console.WriteLine("------------------------Hex1------------------------");
            string hex1 = "A 4 E 6 1 6 7 6 5 6 C 7 3 2 0 5 5 4 B 2 0 4 C 7 4 6 4 2 E 2 E 2 E 2 E 2 E 2 E 2 E 3 9 C 1 5 A F 4 3";
            string[] hex1Values = hex1.Split(" ");
            var hexFormatted1 = FormatHex(hex1Values);
            bitA = BoolCheck1(hexFormatted1[0]);
            bitB = BoolCheck2(hexFormatted1[0]);
            bitC = BoolCheck3(hexFormatted1[0]);
            bitD = BoolCheck4(hexFormatted1[0]);
            textA = TextValue(hexFormatted1[1]);
            shortA = ShortValue(hexFormatted1[2]);
            dateTimeA = DateTimeValue(hexFormatted1[3]);
            Console.WriteLine($"HexString = 'A'\nBitA = {bitA}\nBitB = {bitB}\nBitC = {bitC}\nBitD = {bitD}\n" +
                $"\nHexString = '4E6167656C7320554B204C74642E2E2E2E2E2E2E'\n{textA}\n" +
                $"\nHexString = '39C1'\nShortA = {shortA}\n" +
                $"\nHexString = '5AF43'\nDateTimeA = {dateTimeA.ToShortDateString()}\n");

            Console.WriteLine("------------------------Hex2------------------------");
            string hex2 = "F 4 2 6 1 7 4 7 4 6 C 6 5 2 0 6 F 6 6 2 0 4 8 6 1 7 3 7 4 6 9 6 E 6 7 7 3 2 0 2 0 0 4 2 A 0 5 F 4 8";
            string[] hex2Values = hex2.Split(" ");
            var hexFormatted2 = FormatHex(hex2Values);
            bitA = BoolCheck1(hexFormatted2[0]);
            bitB = BoolCheck2(hexFormatted2[0]);
            bitC = BoolCheck3(hexFormatted2[0]);
            bitD = BoolCheck4(hexFormatted2[0]);
            textA = TextValue(hexFormatted2[1]);
            shortA = ShortValue(hexFormatted2[2]);
            dateTimeA = DateTimeValue(hexFormatted2[3]);
            Console.WriteLine($"HexString = 'F'\nBitA = {bitA}\nBitB = {bitB}\nBitC = {bitC}\nBitD = {bitD}\n" +
                $"\nHexString = '426174746C65206F662048617374696E67732020'\n{textA}\n" +
                $"\nHexString = '042A'\nShortA = {shortA}\n" +
                $"\nHexString = '05F48'\nDateTimeA = {dateTimeA.ToShortDateString()} \n");

            Console.WriteLine("------------------------Hex3------------------------");
            string hex3 = "0 4 1 6 C 6 2 6 5 7 2 7 4 2 0 4 5 6 9 6 E 7 3 7 4 6 5 6 9 6 E 2 0 4 2 6 F 7 2 6 E 2 B 6 7 4 E 6 6 0";
            string[] hex3Values = hex3.Split(" ");
            var hexFormatted3 = FormatHex(hex3Values);
            bitA = BoolCheck1(hexFormatted3[0]);
            bitB = BoolCheck2(hexFormatted3[0]);
            bitC = BoolCheck3(hexFormatted3[0]);
            bitD = BoolCheck4(hexFormatted3[0]);
            textA = TextValue(hexFormatted3[1]);
            shortA = ShortValue(hexFormatted3[2]);
            dateTimeA = DateTimeValue(hexFormatted3[3]);
            Console.WriteLine($"HexString = '0'\nBitA = {bitA}\nBitB = {bitB}\nBitC = {bitC}\nBitD = {bitD}\n" +
                $"\nHexString = '416C626572742045696E737465696E20426F726E'\n{textA}\n" +
                $"\nHexString = '2B67'\nShortA = {shortA}\n" +
                $"\nHexString = '4E660'\nDateTimeA = {dateTimeA.ToShortDateString()} \n");

            Console.WriteLine("------------------------Hex4------------------------");
            string hex4 = "C 4 1 6 C 6 1 6 E 2 0 5 4 7 5 7 2 6 9 6 E 6 7 2 0 4 5 6 E 6 9 6 7 6 D 6 1 2 0 2 0 0 8 A E 5 1 5 D A";
            string[] hex4Values = hex4.Split(" ");
            var hexFormatted4 = FormatHex(hex4Values);
            bitA = BoolCheck1(hexFormatted4[0]);
            bitB = BoolCheck2(hexFormatted4[0]);
            bitC = BoolCheck3(hexFormatted4[0]);
            bitD = BoolCheck4(hexFormatted4[0]);
            textA = TextValue(hexFormatted4[1]);
            shortA = ShortValue(hexFormatted4[2]);
            dateTimeA = DateTimeValue(hexFormatted4[3]);
            Console.WriteLine($"HexString = 'C'\nBitA = {bitA}\nBitB = {bitB}\nBitC = {bitC}\nBitD = {bitD}\n" +
                $"\nHexString = '416C616E20547572696E6720456E69676D612020'\n{textA}\n" +
                $"\nHexString = '08AE'\nShortA = {shortA}\n" +
                $"\nHexString = '515DA'\nDateTimeA = {dateTimeA.ToShortDateString()} \n");

            Console.WriteLine("------------------------Hex5------------------------");
            string hex5 = "9 4 3 6 8 6 5 7 2 6 E 6 F 6 2 7 9 6 C 2 0 4 4 6 9 7 3 6 1 7 3 7 4 6 5 7 2 2 1 2 1 2 3 A 3 5 7 F 3 4";
            string[] hex5Values = hex5.Split(" ");
            var hexFormatted5 = FormatHex(hex5Values);
            bitA = BoolCheck1(hexFormatted5[0]);
            bitB = BoolCheck2(hexFormatted5[0]);
            bitC = BoolCheck3(hexFormatted5[0]);
            bitD = BoolCheck4(hexFormatted5[0]);
            textA = TextValue(hexFormatted5[1]);
            shortA = ShortValue(hexFormatted5[2]);
            dateTimeA = DateTimeValue(hexFormatted5[3]);
            Console.WriteLine($"HexString = '9'\nBitA = {bitA}\nBitB = {bitB}\nBitC = {bitC}\nBitD = {bitD}\n" +
                $"\nHexString = '436865726E6F62796C2044697361737465722121'\n{textA}\n" +
                $"\nHexString = '23A3'\nShortA = {shortA}\n" +
                $"\nHexString = '57F34'\nDateTimeA = {dateTimeA.ToShortDateString()} \n");
        }

        /// <summary>
        /// Method used to format each hex string into its required fields using expected number of bits.
        /// </summary>
        /// <param name="hexValues"></param>
        /// <returns>List of formated hex string.</returns>
        public static List<string> FormatHex(string[] hexValues)
        {
            List<string> formattedHexList = new List<string>();

            var tempHex1 = "";
            // set first hex for the bool representations --> reference - (4 bits single per hex value)
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

        /// <summary>
        /// Convert hex to byte array.
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns>hex string converted to byte array.</returns>
        public static byte[] StringToByteArray(string hexString)
        {
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return bytes;
        }

        public static bool BoolCheck1(string hexString)
        {
            // set hex as a byte array -->
            byte[] data = StringToByteArray(hexString);
            // set byte array as bit array -->
            var bits = String.Join(String.Empty, hexString.Select(c => Convert.ToString(Convert.ToUInt32(c.ToString(), 16), 2).PadLeft(4, '0')));

            if (bits[0] == '1')
            {
                return true;
            }

            return false;
        }

        public static bool BoolCheck2(string hexString)
        {
            var data = StringToByteArray(hexString);
            var bits = String.Join(String.Empty, hexString.Select(c => Convert.ToString(Convert.ToUInt32(c.ToString(), 16), 2).PadLeft(4, '0')));

            if (bits[1] == '1')
            {
                return true;
            }

            return false;
        }

        public static bool BoolCheck3(string hexString)
        {
            var data = StringToByteArray(hexString);
            var bits = String.Join(String.Empty, hexString.Select(c => Convert.ToString(Convert.ToUInt32(c.ToString(), 16), 2).PadLeft(4, '0')));

            if (bits[2] == '1')
            {
                return true;
            }

            return false;
        }

        public static bool BoolCheck4(string hexString)
        {
            var data = StringToByteArray(hexString);
            var bits = String.Join(String.Empty, hexString.Select(c => Convert.ToString(Convert.ToUInt32(c.ToString(), 16), 2).PadLeft(4, '0')));

            if (bits[3] == '1')
            {
                return true;
            }

            return false;
        }

        public static string TextValue(string hexString)
        {
            // set hex into a byte array -->
            var data = StringToByteArray(hexString);
            // set byte array into bit array -->
            var bits = new BitArray(data);
            // convert bits to ASII characters -->
            string stringValue = Encoding.ASCII.GetString(data);

            return stringValue;
        }

        public static short ShortValue(string hexString)
        {
            //var data = StringToByteArray(hexString);

            // set hex as bit array -->
            var bits = Convert.ToString(Convert.ToInt32(hexString.ToString(), 16), 2).PadLeft(4, '0');
            // convert bit values to short value -->
            short shortValue = Convert.ToInt16(bits, 2);

            return shortValue;
        }

        public static DateTime DateTimeValue(string hexString)
        {
            // set hex as bit array -->
            var bits = Convert.ToString(Convert.ToInt32(hexString.ToString(), 16), 2).PadLeft(4, '0');
            // convert bit values to int value -->
            int intValue = Convert.ToInt32(bits, 2);

            // set dateTime to start from correct date and increment starter value with int value -->
            DateTime dt = new DateTime(1000, 01, 01).AddDays(intValue);

            return dt;
        }
    }
}
