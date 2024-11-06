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

namespace admin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        companyEntities1 db=new companyEntities1(); 
        public MainWindow()
        {
            InitializeComponent();
            dataa.ItemsSource = db.eemployees.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            eemployee rec= new eemployee();
            rec.empname = ntxt.Text;
            rec.empstate= stxt.Text;
            db.eemployees.Add(rec);
            db.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dataa.ItemsSource = db.eemployees.ToList();
        }
    }
}
