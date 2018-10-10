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
    /// 會員管理.xaml 的互動邏輯
    /// </summary>
    public partial class 會員管理 : Window
    {
        public 會員管理()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //NorthwindEntities dbContext = new NorthwindEntities();
            //var account = dbContext.Members.Where(x => x.account == email.Text);

        }
    }
}
