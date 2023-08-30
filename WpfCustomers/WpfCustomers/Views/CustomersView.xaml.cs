using System.Collections.Generic;
using System.Windows.Controls;
using WpfCustomers.Models;
using WpfCustomers.Services;

namespace WpfCustomers.Views
{
    public partial class CustomersView : UserControl
    {
        //WRONG
        //readonly CustomerService service = new CustomerService(); 

        readonly CustomerService service = CustomerService.Init;

        public CustomersView()
        {
            InitializeComponent();

            service.UpdateAct += UpdateCustomers;

            service.AddCustomer(new Customer { Name = "Test" });

            //service.UpdateAct(new List<Customer>());
            //service.UpdateAct?.Invoke(new List<Customer>());

            //int i = 5;
            //i += 2;
            //i += 2;
            //i += 2;
            //i += 1;
        }

        private void UpdateCustomers(List<Customer> customers)
        {
            lvCustomers.Items.Clear();

            customers.ForEach(c => lvCustomers.Items?.Add(c));
        }
    }
}