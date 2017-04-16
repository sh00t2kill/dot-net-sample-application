using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempLibrary
{
    //List
    //Dictionary
    //HashTablle
    //Stack
    //Queue
    //LinkedList
    //HashList


    public class Class1
    {
        public List<Customer> TempMethod()
        {
            string[] aa = new string[] { "","",""};
            string[] aaa = new string[4] ;

            aaa[0] = "";



            List<Customer> xx = new List<Customer>();

            ArrayList xxxx = new ArrayList();
            xxxx.Add(true);
            xxxx.Add("");

            Dictionary<int, string> yy = new Dictionary<int, string>();
            yy.Add(1, "");

            Hashtable x = new Hashtable();
            x.Add(1, "");
            x.Add("", true);




            List<Customer> lstCustomer = new List<Customer>();
            lstCustomer.Add(new Customer() { Age = 12, CustomerName = "aaaa", Gender = "M" });
            lstCustomer.Add(new Customer() { Age = 12, CustomerName = "aaaa", Gender = "M" });

            lstCustomer.Add(new Customer() { Age = 12, CustomerName = "aaaa", Gender = "M" });


            return lstCustomer;
        }
    }

    public class Customer
    {
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

    }

}
