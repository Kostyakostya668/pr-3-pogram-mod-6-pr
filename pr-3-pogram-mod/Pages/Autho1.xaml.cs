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

namespace pr_3_pogram_mod.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autho1.xaml
    /// </summary>
    public partial class Autho1 : Page
    {
        public Autho1()
        {
            InitializeComponent();
        }

        private void btnEnterGuests_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Client());
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
