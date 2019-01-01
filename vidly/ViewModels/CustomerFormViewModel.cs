using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

        public String Title
        {
            get
            {
                if (Customer != null && Customer.Id !=0)
                {
                    return "Edit Customer";
                }
                return "New Customer";

            }
        }
    }
}