using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   internal class Employee
    {
       public int eid { get; set; } //Auto Implemented properties
        //these are by default private members if we make it public it will be difficult to control the data entry and data restruction so to overcome this we use Methods in class to set these private values and make them accessible outside the class
        #region
       // public int Eid
       // {
        //    get { return eid; }
        //    set
        //    {
         //       if (eid > 0)
          //      { eid = value; }
          //      else
          //      { eid = 0; }
          //  }
      //  }
#endregion
        public string ename { get; set; } //Auto Implemented properties
        #region
        // public string Ename
        //{
        //  get { return ename; }
        //set { ename = value; }
        //}
        #endregion

       public Employee()
        {
            eid = 100;
            ename = "ABC";
        }

        public Employee(int eid, string ename)
        {
            this.eid = eid;
            this.ename = ename;
        }


        //This public method is accessible outside the class so that we can enter the detials of our private member
        public void Acceptdetails()
        {
            Console.WriteLine("Enter eid and ename");
            eid = Convert.ToInt32(Console.ReadLine());
            ename = Console.ReadLine();
        }
        public void Displaydetails()
        {
            Console.WriteLine("Your details are ");
            Console.WriteLine("Eid:"+eid);
            Console.WriteLine("Ename:-"+ename);
        }
    }
    public class empclient
    {
        public static void main()
        {
            Employee e = new Employee();

            // e.Acceptdetails();
            // e.Displaydetails();
            e.eid = 90;
            e.ename = "shyam";
            Console.WriteLine(e.eid);
            Console.WriteLine(e.ename);
            Employee e1 = new Employee();
            e1.Displaydetails();
            Employee e2 = new Employee(970, "Sakshi");
            e2.Displaydetails();


        }
    }
}
