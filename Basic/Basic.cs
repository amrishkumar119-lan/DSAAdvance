using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAdvance.Basic
{
    //public class A
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public A aaa { get; set; }


    //    public A()
    //    {

    //    }

    //    public A(int _Id,string _name) {
    //        Id = _Id;
    //        Name = _name;
    //        aaa = new A();
    //        aaa.Id = 555;
    //        aaa.Name = "Aman";

    //    }
    //    public A(A obj)
    //    {
    //        this.Id = obj.Id;
    //        this.Name = obj.Name;
    //        aaa = new A();
    //        aaa.Id = 555;
    //        aaa.Name = "Aman";
    //    }

    //    public string Add()
    //    {
    //        return Name+" "+aaa.Name;
    //    }
    //}

    
    // OOP Concept: Shallow Copy vs Deep Copy
    // - Shallow copy: copies value types, but reference type fields share the same object.
    // - Deep copy: creates new copies of reference type fields too.
    public  class info
    {
        public int id;
        public info(int _id)
        {
            id = _id;
        }
    }

    public class person
    {
        public int Age;
        public string Name;
        public info info;

        // Shallow copy - 'info' reference is shared between original and copy.
        public person shollCopy()
        {
            return (person)MemberwiseClone();
        }

        // Deep copy - new 'info' object so changes don't affect the original.
        public person deepCopy()
        {
            person person = (person)MemberwiseClone();
            person.info = new info(info.id);
            return person;
        }

    }

    // Demo of shallow copy behaviour - observe how p1.info.id and p2.info.id are linked.
    public class Basic
    {

        // Renamed from Main to Demo to allow a single project entry point.
        // Call Basic.Demo() from Program.cs to run this demo.
        public static void Demo()
        {
            int i = 123;
            char[] str = i.ToString().ToCharArray();
            person p1 = new() { Age = 29, Name = "Amrish", info = new info(5512) };
            person p2 = p1.shollCopy();

            Console.WriteLine("p1 instnce Value");
            DisplayValues(p1);
            Console.WriteLine("p2 instnce Value");
            DisplayValues(p2);

            p1.Age = 27;
            p1.Name= "Test";
            p1.info.id = 5000;
            p2.Age = 28;
            p2.Name = "hudsgfusd";
            p2.info.id = 70000;
            Console.WriteLine("Change value");
            Console.WriteLine("p1 instnce Value");
            DisplayValues(p1);
            Console.WriteLine("p2 instnce Value");
            DisplayValues(p2);

            //person p3=p1.deepCopy();

            //p1.Age = 22;
            //p1.Name = "Naman";
            //p1.info.id = 6000;
            //Console.WriteLine("p1 deep instnce Value");
            //DisplayValues(p1);
            //Console.WriteLine("p2 deep instnce Value");
            //DisplayValues(p2);
        }

        public static void DisplayValues(person p)
        {
            Console.WriteLine($" Name:{p.Name:s},age:{p.Age:d}");
            Console.WriteLine($" value:{p.info.id}");
        }

    }
}
