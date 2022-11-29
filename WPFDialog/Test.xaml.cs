using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WPFDialog
{
    /// <summary>
    /// Test.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Test : Window
    {
        public Test()
        {
            InitializeComponent();
            FoodName.Focus();
        }
        //-----------------------------------
        // prop 탭 두 번
        //public int MyProperty { get; set; }
        //-----------------------------------

        //-----------------------------------
        // propfull 탭 두 번
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        //-----------------------------------

        //private string _MSName;

        public string FName
        {
            get { return FoodName.Text; }
        }


        public string Finde
        {
            get { return Inde.Text; }
        }

        public string FCountry => Country.Text;
        private void OnOkay(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void OnCancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
