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
        }
    }
}
