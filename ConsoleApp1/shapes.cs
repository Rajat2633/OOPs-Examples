using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class shapes
    {
        public string color { get; set; }
        public float Area { get; set; }

        public virtual void  Acceptdetails()
        {
            Console.WriteLine("enter color");
            color = Console.ReadLine();
        }

        public virtual void displaydetails()
        {
            Console.WriteLine("Color is "+color);
        }
        public virtual void calculatearea()
        {
            Console.WriteLine("Area method is called");
        }
    }

    class rectangle:shapes
    {
        public int length { get; set; }
        public int bredth { get; set; }

        public override void Acceptdetails()
        {
            //a virtual method has an implementation in a base class as well as derived the class
            //It is used when a method's basic functionality is the same but sometimes more functionality is needed
            //in the derived class. A virtual method is created in the base class that can be overriden in the derived class.
            //We create a virtual method in the base class using the virtual keyword and
            //that method is overriden in the derived class using the override keyword.
            base.Acceptdetails();
            Console.WriteLine("Enter length and vredth");
            length = Convert.ToInt32(Console.ReadLine());
            bredth = Convert.ToInt32(Console.ReadLine());

        }
        public override void displaydetails()
        {
            Console.WriteLine("length is " +length);
            Console.WriteLine("bredth is " + bredth);
        }
        public override void calculatearea()
        {
            Console.WriteLine("Area method is called");
            int area = length * bredth;
            Console.WriteLine("Area is "+area);
        }

    }

    class circle : shapes
    {
        public int radius { get; set; }
        

        public override void Acceptdetails()
        {
            //a virtual method has an implementation in a base class as well as derived the class
            //It is used when a method's basic functionality is the same but sometimes more functionality is needed
            //in the derived class. A virtual method is created in the base class that can be overriden in the derived class.
            //We create a virtual method in the base class using the virtual keyword and
            //that method is overriden in the derived class using the override keyword.
            //base.Acceptdetails();
            Console.WriteLine("Enter Radius of the Circle");
            radius = Convert.ToInt32(Console.ReadLine());
         

        }
        public override void displaydetails()
        {
            Console.WriteLine("radius is " + radius);
           
        }
        public override void calculatearea()
        {
            Console.WriteLine("Area method is called");
            double area = 3.14 * radius * radius;
            Console.WriteLine("Area is " + area);
        }

    }
}
