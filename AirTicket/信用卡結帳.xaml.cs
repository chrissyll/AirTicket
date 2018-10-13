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
using System.Windows.Shapes;

namespace AirTicket
{
    /// <summary>
    /// 信用卡結帳.xaml 的互動邏輯
    /// </summary>
    public partial class 信用卡結帳 : Window
    {
        public 信用卡結帳()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (visa_rdbtn.IsChecked == true)
            {
                //newMember.Member_Gender = "男";
            }
            else if (master_rdbtn.IsChecked == true)
            {
                //newMember.Member_Gender = "女";
            }
            else if (ae_rdbtn.IsChecked == true)
            {
                //newMember.Member_Gender = "女";
            }
            else
            {
                MessageBox.Show("請點選信用卡別");
                return;     //就不會往下走
            }
        }
    }
}
