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

namespace PracticingCRUDSQLite
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

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

        }
        public void Create()
        {
            using (DataContext context = new DataContext())
            {
                var name = txtName.Text;
                var address = txtAddress.Text;
                if (name != null && address != null)
                {
                    context.Users.Add(new User() { Name = name, Address = address });
                    context.SaveChanges();
                }
                else
                    return;

            }
        }
        public void Read()
        {

        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
    }
}
