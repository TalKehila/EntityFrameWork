using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WpfCustomers.Models;
using WpfCustomers.Services;

namespace WpfCustomers.Views
{
    public partial class NewCustomerView : UserControl
    {
        //WRONG
        //readonly CustomerService service = new CustomerService();

        readonly CustomerService service = CustomerService.Init;

        public NewCustomerView()
        {
            InitializeComponent();
        }

        private void AddCustomerClick(object sender, RoutedEventArgs e)
        {
            service.AddCustomer(new Customer { Name = tbName.Text, Age = int.Parse(tbAge.Text) });

            tbName.Text = "";
            tbAge.Text = "";
        }
    }
}