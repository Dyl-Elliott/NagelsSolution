using System;
using System.Collections.Generic;
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
        }

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
    }
}
