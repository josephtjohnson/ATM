using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Customer
    {
        private readonly int id;
        private string username;
        private string password;

        public Customer(int id, string username, string password) 
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }


        public int GetId() { return id; }

        public string GetUsername() { return username; }

        public string GetPassword() { return password; }

    }

}
