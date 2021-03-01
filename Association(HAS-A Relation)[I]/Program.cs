using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_HAS_A_Relation__I_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Address address1 = new Address(45,10,"Dhaka");
            //Account account1 = new Account(1001,"Shakib",2000,address1);
            //account1.PrintAccount();

            //Account account2 = new Account(2002, "Tamim", 3000, new Address(5, 7, "Chittagong"));
            //account2.PrintAccount();

            Bank ourBank = new Bank("Developer's bank", 5);
            ourBank.AddAccount(new Account(1001, "Shakib", 2000, new Address(45, 10, "Dhaka")));
            ourBank.AddAccount(new Account(1002, "Mushfiq", 4000, new Address(45, 10, "Sylhet")));
            ourBank.AddAccount(new Account(2002, "Tamim", 3000, new Address(5, 7, "Chittagong")));
            //ourBank.PrintAllAccounts();
            ourBank.SearchAccount(100);
            
        }
    }
}
