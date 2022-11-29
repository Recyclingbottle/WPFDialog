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

namespace WPFDialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            Test test = new Test();
            if (test.ShowDialog() != true)
                return;

            Result.Text += $"{test.FName}의 주재료는 {test.Finde} 이고 {test.FCountry} {(HasJongsung(test.FName) ? "이" : "가")} 추가되었습니다.\n";
        }
        public bool HasJongsung(string str)
        {
            if (str.Length < 1)
                return true;
            char last = str[str.Length - 1];
            return (last - 44032) % 28 != 0 ? true : false;
        }
    }
}
