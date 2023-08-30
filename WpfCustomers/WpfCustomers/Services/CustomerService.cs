using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;
using WpfCustomers.Models;
using WpfCustomers.Views;
using static WpfCustomers.Views.CustomersView;

namespace WpfCustomers.Services
{
    public class CustomerService
    {
        DataContext data = new DataContext();
        //readonly List<Customer> customers = new List<Customer>(); // this is not needed for DB this is need for the delegate


        //public Action<List<Customer>> UpdateAct { get; set; }
        public event Action<List<Customer>> UpdateAct;

        #region Singleton (Design Pattern)
        //private static CustomerService init;
        //public static CustomerService Init
        //{
        //    get
        //    {
        //        if (init == null)
        //            init = new CustomerService();
        //        return init;
        //    }
        //} 
        public static CustomerService Init { get; } = new CustomerService();// short way like lines 21 to 30 
        //public object Data { get => data; set => data = value; }
        #endregion

        private CustomerService()
        {
            data.Customers.Add(new Customer { Name = "First" });
            data.Customers.Add(new Customer { Name = "Second" });
        }

        public void AddCustomer(Customer customer)
        {
            data.Customers.Add(customer);
            UpdateAct?.Invoke(data.Customers.ToList());

            data.SaveChanges();
        }
    }
}