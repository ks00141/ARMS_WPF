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
using System.Windows.Threading;

namespace ARMS_WPF
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tb_content.Text = "Window Loaded";
            setDateTime();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            setDateTime();
        }

        private void btn_destroy_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void setDateTime()
        {
            txt_date.Text = DateTime.Now.ToShortDateString();
            txt_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
