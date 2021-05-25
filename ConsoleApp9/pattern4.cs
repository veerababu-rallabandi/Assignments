using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    partial class partialclass
    {
        public override string ToString()
        {
            return "{"+a+","+name+"}";
        }
        public void say()
        {
            Console.WriteLine("hello");
        }
        partial void sum()
        {
            Console.WriteLine("something");
        }
    }
    class pattern4
    {
        static void Main(string[] args)
        {

            // way1 calling
            // partialclass p = new partialclass() { a=10,name="veerababu"};
            //Console.WriteLine(p.ToString());

            //way 2 calling(using anonyoums object)
            Console.WriteLine(new partialclass() { a=10,name="veerababu"}.ToString());
            new partialclass().say();
            new partialclass().some();


            //way 3
           //  Employee e = new Employee() { a=10,name="veerababu"};
            
           // Console.WriteLine(e.a);
            //Console.WriteLine(e.name);

           
        }
        
    }
}
