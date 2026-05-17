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

        // Renamed from Main to Demo. Note: GetF is null here - this demo currently
        // throws NullReferenceException; intent was to demonstrate interface usage.
        // Fix by assigning GetF = new a(); before calling.
        public static void Demo()
        {
            GetF = new a();
            GetF.Show();
            GetF.Hide();
            GetF.Get();
        }
    }
}
