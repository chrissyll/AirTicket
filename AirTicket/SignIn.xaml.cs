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
    /// SignIn.xaml 的互動邏輯
    /// </summary>
    public partial class SignIn : Window
    {
        public SignIn()
        {
            InitializeComponent();
        }
        AirEntities dbContext = new AirEntities();
        private void login_Click(object sender, RoutedEventArgs e)
        {
            if (email_txt.Text == "")
            {
                email_txt.BorderBrush = Brushes.Red;
            }
            else
            {
                email_txt.BorderBrush = Brushes.LightGray;  //不是預設值
            }
            if (password_txt.Password == "")
            {
                password_txt.BorderBrush = Brushes.Red;
            }
            else
            {
                password_txt.BorderBrush = Brushes.LightGray;
            }
            
            var result = dbContext.Members.AsEnumerable().FirstOrDefault(x => x.Member_Account == email_txt.Text && x.Member_Password == password_txt.Password);

            if (result != null)
            {
                MessageBox.Show("登入成功");
                this.Hide();
                會員管理 main = new 會員管理();
                main.Show();
            }
            else
            {
                label.Content = "帳號或密碼不正確";
                label.Foreground = Brushes.Red;
                email_txt.Clear();
                password_txt.Clear();
            }
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void adduser_btn_Click(object sender, RoutedEventArgs e)
        {
            會員新增 main = new 會員新增();
            main.Show();
            this.Hide();
        }
    }
}
