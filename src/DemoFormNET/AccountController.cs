using BanckClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFormNET
{
    public class AccountController
    {
        private Account model;

        public AccountController(Account aAccount)
        {
            model = aAccount;
        }

        
        public void DisplayBalance()
        {
            //Console output
            Console.WriteLine("The current balance are " + model.CurrentBalance );
        }


    }
}
