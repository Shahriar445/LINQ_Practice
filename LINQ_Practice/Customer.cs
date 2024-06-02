using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    public  class Customer
    {
        public int Revinue { get; set; }
        public Customer(int revinue) { 
        
            Revinue = revinue;
        }
    }
    public class DetailsCustomer
    {
        public List<Customer> customers = new List<Customer>();
        public DetailsCustomer()
        {
            customers.Add(new Customer (1));
            customers.Add(new Customer (44));
            customers.Add(new Customer (4542));
            customers.Add(new Customer (112));
            customers.Add(new Customer (4414242));
            customers.Add(new Customer (14));
            customers.Add(new Customer (2540));
            customers.Add(new Customer (120));
            customers.Add(new Customer (1000));
            customers.Add(new Customer (1255));
            customers.Add(new Customer (1242));
            customers.Add(new Customer (2101));
            customers.Add(new Customer (12));
        }
        public IEnumerable<Customer>AddIEnumerable()
        {
            return customers.AsQueryable();
        }
        public IQueryable<Customer> GetQueryable()
        {
            return customers.AsQueryable();
        }

    }





}
