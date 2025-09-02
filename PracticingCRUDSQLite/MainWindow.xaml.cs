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
        private List<User> DatabaseUsers;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            Create();
        }
       
        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            Read();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }
        public void Create()
        {
            using (DataContext context = new DataContext())
            {
                var name = txtName.Text;
                var address = txtAddress.Text;
                if (name != string.Empty && address != string.Empty)
                {
                    context.Users.Add(new User() { Name = name, Address = address });
                    context.SaveChanges();
                }

            }
        }
        public void Read()
        {
            using (DataContext context = new DataContext())
            {
                DatabaseUsers = context.Users.ToList();
                UserList.ItemsSource = DatabaseUsers;
            }
        }
        public void Update()
        {
            using (DataContext context = new DataContext())
            {
                User selectedUser = UserList.SelectedItem as User;//will select the user item and convert to user type - this way we can get the Id
                var name = txtName.Text;
                var address = txtAddress.Text;
                if (name != string.Empty && address != string.Empty)
                {

                    User user = context.Users.Find(selectedUser.Id);//find the user based on the Id property
                    user.Name = name;
                    user.Address = address;

                    context.SaveChanges();
                }

                //this just updates our listview
                DatabaseUsers = context.Users.ToList();
                UserList.ItemsSource = DatabaseUsers;
            }
        }
        public void Delete()
        {
            using (DataContext context = new DataContext())
            {
                User selectedUser = UserList.SelectedItem as User;//will select the user item and convert to user type - this way we can get the Id
                User user = context.Users.Find(selectedUser.Id);//find the user based on the Id property

                context.Users.Remove(user);
                context.SaveChanges();


                //this just updates our listview
                DatabaseUsers = context.Users.ToList();
                UserList.ItemsSource = DatabaseUsers;
            }
        }

    }
}
