using Console_CodeFirst.Models;
using System.Collections.Generic;

namespace Console_CodeFirst
{
    //MODEL = מבנה של הקלאס
    public class Customer
    {
        public int Id { get; set; }         //Old-Style: CustomerId
        public string Name { get; set; }
        public bool Status { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}