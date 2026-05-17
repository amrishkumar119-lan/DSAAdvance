using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAdvance.Basic
{
    // OOP Concept: Interface Implementation
    // An interface defines a contract; the class implementing it must define all methods.
    public interface IF
    {
        public void Show();
        public void Hide();
        public void Get();
    }
    public class a:IF
    {
        public void Show()
        {
            Console.WriteLine("Hello");
        }

        public void Hide()
        {
            Console.WriteLine("Hide");
        }
        public void Get()
        {
            Console.WriteLine("Hii Get");
        }
    }

   
    public class BasicOops
    {
       private static IF GetF;

        public static void Main()
        {
            GetF.Show();
            GetF.Hide();
            GetF.Get();
          
        }
    }
}
