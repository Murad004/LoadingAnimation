using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp4
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
       

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            using (Loading loading=new Loading(Simulator))
            {
                loading.ShowDialog();
            }
        }

        void Simulator()
        {
            for (int i = 0; i < 800; i++)
                Thread.Sleep(5);
        }
    }
}
