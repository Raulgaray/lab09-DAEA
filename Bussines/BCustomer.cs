using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace Bussines
{
    public class BCustomer
    {

        public List<Customer> FindByName() 
        { 
            List<Customer> customers = new List<Customer>();
            customers = DCustomer.GetAll();
            return customers;
            /*
            foreach (var cust in customers)
            {
                if (cust.Name.Equals(name))
                {
                    return cust;
                }
            }

            return null;*/
        }
    }
}
