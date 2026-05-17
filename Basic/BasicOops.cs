using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAdvance.Basic
{
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
