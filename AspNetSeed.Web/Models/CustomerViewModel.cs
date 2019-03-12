using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetSeed.Web.Models
{
    public class CustomerViewModel
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public CustomerViewModel(int id, string firstName)
        {
            this.Id = id;
            this.FirstName = firstName;
        }
    }
}