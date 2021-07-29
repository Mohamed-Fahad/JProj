using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjThirdApplication
{
    //Generic Class
    class Sample<T>
    {
        T Name;
        T City;

        internal Sample(T Name,T City)
        {
            this.Name = Name;
            this.City = City;
        }

        //Normal Method
        internal void Add(int x,int y)
        {
            Console.WriteLine("Addition is {0}", (x+y));
        }

        //Generic Method
        internal void Swap<T>(T x, T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;

            Console.WriteLine("X is {0} | Y is {1}", x, y);
        }

    }

    /*Generic Constraint
     * where T:struct  //value type
     * where T:class   //reference type
     * where T:new     //default parameter constraint
     * where T:<interface name>
    */

    class Student<T> where T : struct 
    {

    }

    class Generics_Class_and_Methods
    {
        static void Main()
        {
            Sample<string> sample = new Sample<string>("Arun","Mumbai");
            sample.Swap<int>(6, 8);
            sample.Swap<string>("Good","Morning");


            //Struct Constraint
            //error because student class will accept only struct value(Value type)
            //Student<string> student=new Student<string>(); //because string is a reference type whereas struct demands value type

            Student<int> student = new Student<int>(); //this is accepted because int is value type
        }
    }
}
