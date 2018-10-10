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
    /// 會員新增.xaml 的互動邏輯
    /// </summary>
    public partial class 會員新增 : Window
    {
        public 會員新增()
        {
            InitializeComponent();
        }
        AirEntities dbContext = new AirEntities();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (firstname_txt.Text == "")
            {
                firstname_txt.BorderBrush = Brushes.Red;
            }
            else
            {
                firstname_txt.BorderBrush = Brushes.LightGray;  //不是預設值
            }

            if (lastname_txt.Text == "")
            {
                lastname_txt.BorderBrush = Brushes.Red;
            }
            else
            {
                lastname_txt.BorderBrush = Brushes.LightGray;
            }

            if (password_txt.Password == "")
            {
                password_txt.BorderBrush = Brushes.Red;
            }
            else
            {
                password_txt.BorderBrush = Brushes.LightGray;
            }

            if (phone_txt.Text == "")
            {
                phone_txt.BorderBrush = Brushes.Red;
            }
            else
            {
                phone_txt.BorderBrush = Brushes.LightGray;
            }

            if (email_txt.Text == "")
            {
                email_txt.BorderBrush = Brushes.Red;
            }
            else
            {
                email_txt.BorderBrush = Brushes.LightGray;  //不是預設值
            }
            string FirstName = this.firstname_txt.Text;
            string LastName = this.lastname_txt.Text;
            string Password = this.password_txt.Password;   //***
            string Phone = this.phone_txt.Text;
            string Email = this.email_txt.Text;

            //Password = HashPasswordForStoringInConfigFile(Password + salt, "sha1");

            Member newMember = new Member();
            newMember.Member_En_FirstName = FirstName.ToUpper();
            newMember.Member_En_LastName = LastName.ToUpper();
            newMember.Member_Password = Password;   //***
            newMember.Member_Phone = Phone;
            newMember.Member_Account = Email;

            if (mr_rdbtn.IsChecked == true)
            {
                newMember.Member_Gender = "男";
            }
            else if (ms_rdbtn.IsChecked == true)
            {
                newMember.Member_Gender = "女";
            }
            else
            {
                MessageBox.Show("請選擇性別");
                return;     //就不會往下走
            }

            dbContext.Members.Add(newMember);
            dbContext.SaveChanges();
            MessageBox.Show("加入成功");

            信用卡結帳 main = new 信用卡結帳();
            main.Show();
            this.Close();
        }
    }
}
