using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppTask
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //FirstButton
        {            
            ListBoxOne.ItemsSource = SplitText(TextBoxOne.Text);
        }

        private string[] SplitText(string text)
        {
            string[] textArray = text.Split(' ');
            return textArray;
        }

        private string Reverse(string text)
        {
            string[] textArray = SplitText(text);
            Array.Reverse(textArray);

            string reversedText = null;
            for (int i = 0; i < textArray.Length; i++)
            {
                reversedText += textArray[i] + ' ';
            }
            return reversedText;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //SecondButton
        {
            LabelForTwo.Content = Reverse(TextBoxTwo.Text);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
