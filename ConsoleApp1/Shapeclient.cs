using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Shapeclient
    {
        public static void Main()
        {
            //shapes s = new shapes();
            // rectangle s = new rectangle(); //static polymorphism 
            //s.Acceptdetails();
            //s.calculatearea();
            //s.displaydetails();
            //  circle c = new circle();
            //  c.displaydetails();
            // c.Acceptdetails();
            // c.calculatearea();

            //DYNAMIC POLYMorphism
            shapes s = new rectangle();
            s.Acceptdetails();
            s.calculatearea();
            s.displaydetails();
            s = new circle();
            s.Acceptdetails();
            s.calculatearea(); 
            s.displaydetails();

        }
        
        
    }
}
