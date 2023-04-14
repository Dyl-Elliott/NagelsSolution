using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace NagelsWPFSolution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> hexString = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void HexButtonClick(object sender, RoutedEventArgs e)
        {
            // capture field text from UI, store inside hexString List<> -->
            hexString.Add(BitATextField.Text);
            hexString.Add(BitBTextField.Text);
            hexString.Add(BitCTextField.Text);
            hexString.Add(BitDTextField.Text);
            hexString.Add(TextATextField.Text);
            hexString.Add(ShortATextField.Text);
            hexString.Add(DateTimeATextField.Text);

            // generate a hexadecimal List<object> with UI data -->
            List<object> hexValues = HexVariableGenerator(hexString);

            // "A" -->
            string hexPart1 = BoolToHex(hexValues);

            // "4E 61 67 65 6C 73 20 55 4B 20 4C 74 64 2E 2E 2E 2E 2E 2E 2E" -->
            string hexPart2 = TextToHex(hexValues);

            // "39C1" -->
            string hexPart3 = ShortToHex(hexValues);
        }

        /// <summary>
        /// Format a List<object> into relative variable types.
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns>A List<object> which contains all UI entries correctly stored.</returns>
        private static List<object> HexVariableGenerator(List<string> hexString)
        {
            List<object> output = new List<object>();

            // bool
            bool bitA = bool.Parse(hexString[0]);
            output.Add(bitA);

            // bool
            bool bitB = bool.Parse(hexString[1]);
            output.Add(bitB);

            // bool
            bool bitC = bool.Parse(hexString[2]);
            output.Add(bitC);

            // bool
            bool bitD = bool.Parse(hexString[3]);
            output.Add(bitD);

            // string
            string textA = hexString[4];
            output.Add(textA);

            // short
            short shortA = short.Parse(hexString[5]);
            output.Add(shortA);

            // DateTime
            DateTime dateTimeA = DateTime.Parse(hexString[6]);
            output.Add(dateTimeA);

            return output;
        }

        /// <summary>
        /// Converts the first 4-bits of the expected hex string given boolean values from UI.
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns>Hex value for first 4-bits of the expected hex string.</returns>
        private static string BoolToHex(List<object> hexString)
        {
            // convert boolean values to single bits -->
            short hex1 = Convert.ToInt16(hexString[0]);
            short hex2 = Convert.ToInt16(hexString[1]);
            short hex3 = Convert.ToInt16(hexString[2]);
            short hex4 = Convert.ToInt16(hexString[3]);

            string boolHex = $"{hex1}{hex2}{hex3}{hex4}";

            // convert bits to hex -->
            string hexOutput = Convert.ToInt16(boolHex, 2).ToString("X");

            return hexOutput;
        }

        /// <summary>
        /// Converts placeholder text provided from within UI to hex values.
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns>Hex values for given text entry.</returns>
        private static string TextToHex(List<object> hexString)
        {
            string textInput = (string)hexString[4];

            // convert string to byte array -->
            byte[] bytes = Encoding.Default.GetBytes(textInput);
            // convert byte array values to hex -->
            string hexText = BitConverter.ToString(bytes);

            // format hex for output removing "-" -->
            string hexOutput = hexText.Replace("-", " ");

            return hexOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        private static string ShortToHex(List<object> hexString)
        {
            short numberInput = (short)hexString[5];
            string hexOutput = numberInput.ToString("X");

            return hexOutput;
        }
    }
}
