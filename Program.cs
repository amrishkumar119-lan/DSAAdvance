// See https://aka.ms/new-console-template for more information

using DSAAdvance.Basic;

public class Programs
{
    public static Func<int, int> compose(List<Func<int, int>> funcs)
    {
        
        return (int x) =>
        {
            for (int i = funcs.Count - 1; i >= 0; i--)
            {
                x = funcs[i](x);
            }
            return x;
        };
    }

    public static bool Find()
    {
        //int[] a = { 39, 889, 397, 261, 486, 817, 329, 476, 559, 290, 202, 785, 61, 388, 397, 138, 949, 832, 432, 568, 148, 550, 990, 960, 454, 848, 983, 294, 811, 580, 598, 801, 42, 735, 91, 235, 177, 517, 76, 638, 348, 419, 71, 701, 847, 751, 819, 459, 618, 43, 594, 706, 930, 882, 550, 891 };

        //int[] b = { 290, 848,990, 550, 891 };
        //int[] a = { 11, 7, 1, 13, 21, 3, 7, 3 };
        //int[] b = { 11, 3, 7, 1, 7 };
        //int[] a = [11 ,7 ,1, 13, 21, 3, 7, 3];
        //int[] b = [11, 3, 7 ,1, 7];

        int[] a = [10, 5, 2, 23, 19];
        int[] b = [19, 5, 3];
        
        HashSet<int> set = new HashSet<int>(a);
        foreach (int val in b)
        {
            if (set.Contains(val))
            {

            }
            else { return false; }
        }
        return true;
        HashSet<int> s = new HashSet<int>(b);
        foreach (int k in b)
        {
            if (s.Contains(k))
            {

            }
            else { return false; }
        }
        //Array.Sort(a);
        //Array.Sort(b);
        //int i = 0, j = 0;
        ////bool k = true;
        //while (i < a.Length && j < b.Length)
        //{
        //    if (a[i] < b[j])
        //    {
        //        i++;
        //    }
        //    else if (a[i] == b[j])
        //    {
        //        i++; j++;
        //    }
        //    else
        //    {
        //       return false;
        //    }
        //}

        return true;
    }

    public static void Main()
    {

        int[] arr = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };

        

       


        //List<int> s0=  arr.Where(i =>i== 0).ToList();
        // List<int> s1 = arr.Where(i => i == 1).ToList();
        // List<int> s2 = arr.Where(i => i == 2).ToList();

        //for (int i = 0; i < s0.Count; i++)
        //{
        //    arr[i] = s0[i];
        //}
        //for (int i =0; i < s1.Count; i++) { 
        
        //arr[s0.Count+ i] = s1[i];
        //}
        //for (int i = 0; i <s2.Count; i++)
        //{
        //    arr[s1.Count+s0.Count + i] = s2[i];
        //}

        //for(int i = 0; i < arr.Length; i++)
        //{
        //    Console
        //        .WriteLine(arr[i]);
        //}


        //bool k = Find();
        //Console.WriteLine(k);

        //int[] ints = { 0,5,0,1,0,1 };

        //int[] NewArry =new int[ints.Length];


        //for (int i = 0; i < ints.Length; i++) {
        //    for (int j = i+1; j < ints.Length; j++)
        //    {
        //        int t = ints[j];
        //        if (t<= ints[i])
        //        {
        //            NewArry[i] = ints[j];
        //            t = ints[j];
        //        }
        //        else
        //        {
        //            ints[j] = ints[j + 1];
        //            ints[j + 1] = t;
        //        }
        //    }

        //}

        //int[] ints = { 1, 3, 5, 6 };
        //int t = 5;

        //for(int i = 0; i < ints.Length; i++)
        //{
        //    if (t >= ints[i])
        //    {

        //        if (t == ints[i])
        //        {
        //            Console.WriteLine(i);
        //            break;
        //        }

        //    }
        //    else { Console.WriteLine(i); break; }
        //}



        //var function = new List<Func<int, int>>() {
        //x=>x+1, x=>x*x, x=>2*x
        //};
        ////Array.Sort
        //var result = compose(function);
        //int res = result(4);
        //Console.WriteLine(res);


        //for (int i = 1; i <= 5; i++)
        //{
        //    string k = "";
        //    for (int j = 1; j <= i; j++)
        //    {
        //        k += "*";
        //    }
        //    Console.WriteLine(k);
        //}

        //for (int i = 1; i <= 2; i++)
        //{
        //    string m = "";
        //    for (int j = 1; j <= i; j++)
        //    {
        //        m += j;
        //    }
        //    Console.WriteLine(m);
        //}

        //for (int i = 5; i <0; i--) 
        //{
        //    string j = "";
        //    for(int k=0;k<=i;k++)
        //    {
        //        j += "*";
        //    }
        //    Console.WriteLine(j); 
        //   // Console.ReadLine();
        //}


        //for (int i = 1; i <= 5; i++)
        //{
        //    for (int K = 1; K <= 5 - i; K++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int j = 1; j <= i + i - 1; j++)
        //    {

        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        //for (int i = 5; i > 0; i--)
        //{

        //    for (int j = 1; j <= 5 - i; j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int k = 1; k <= i + i - 1; k++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        //for (int i = 1; i <= 5; i++) {
        //    for (int j = 1; j <= i; j++) {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}
        //for (int i = 5-1; i > 0; i--) {
        //    for (int j = 1; j <= i; j++) { Console.Write("*"); }
        //    Console.WriteLine();

        //}

        //for (int i = 1; i <=5; i++) 
        //{
        //    for (int j = i; j >0; j--) {
        //        if (j%2==0) {
        //            Console.Write("0");

        //        }else {Console.Write("1"); }


        //    }
        //    Console.WriteLine();

        //}

        //for (int i = 1; i <=5; i++) {
        //    for (int j = 1; j <= i; j++) {
        //        Console.Write(j);

        //    }
        //    for (int k =1; k<=((5+5)-(i+i)); k++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int j = i; j > 0; j--)
        //    {

        //        Console.Write(j);

        //    }
        //    Console.WriteLine();

        //}
        //int l = 0;
        //int k = 0;
        //for (int i = 1; i <= 5; i++) 
        //{

        //    //int k = l;

        //    for (int j = 1; j <= i; j++) { 
        //     k++;
        //     //l = k;
        //        Console.Write(" "+k);
        //    }
        //    Console.WriteLine();
        //}


        //  string a2z = "abcdefghijk";
        //  char[] str=a2z.ToCharArray();

        //// char ch = 65;
        // for (int i = 0; i <5; i++)
        // {
        //     for (int j = 0; j <=i; j++)
        //     {
        //         Console.Write(str[j].);
        //     }
        //     Console.WriteLine();
        // }

        //String a2z = "abcdefghijklmnopqrstuvwxyz";
        //char[] str = a2z.ToUpper().ToCharArray();
        //for (int i = 0; i<5; i++)
        //{
        //    for (int j =0; j<=i; j++)
        //    {
        //        Console.Write(str[5-i+j-1]);
        //    }

        //    Console.WriteLine();
        //}

        //for (int i = 5; i > 0; i--) {
        //    for (int j = 1; j <= i; j++) {
        //        Console.Write("*");

        //    }
        //    for (int k = 1; k <= 5-i; k++) { 
        //     Console.Write(' ');
        //    }
        //    for (int k = 1; k <= 5 - i; k++)
        //    {
        //        Console.Write(' ');
        //    }
        //    for (int k = 1; k <= i; k++) { 
        //       Console.Write("*");
        //    }
        //    Console.WriteLine();

        //}
        //for (int i = 1; i <= 5; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("*");

        //    }
        //    for (int k = 1; k <= 5 - i; k++)
        //    {
        //        Console.Write(' ');
        //    }
        //    for (int k = 1; k <= 5 - i; k++)
        //    {
        //        Console.Write(' ');
        //    }
        //    for (int k = 1; k <= i; k++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();

        //}

        //for (int i = 1; i <= 5; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    for (int k = 1; k <= (5+5)-(i+i); k++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for(int m = 1; m <= i; m++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}
        //for (int i = 5-1; i >0; i--)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    for (int k = 1; k <= (5 + 5) - (i + i); k++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int m = 1; m <= i; m++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}


        //int k = 0;
        //for (int i = 5; i > 0; i--)
        //{
        //    int n = k;
        //    for (int j = 1; j <= 5; j++)
        //    {
        //        Console.Write(i+n);
        //        if (n > 0)
        //        {
        //            n--;
        //        }

        //    }
        //    k++;
        //    for (int j = 1; j <= 5; j++)
        //    {
        //        Console.Write(i);
        //        if (n > 0)
        //        {
        //            n--;
        //        }

        //    }


        //    Console.WriteLine();

        //}

        //for (int i = 5; i > 0; i--)
        //{
        //    int n = k;
        //    for (int j = 1; j <= 5; j++)
        //    {
        //        Console.Write(i);
        //        if (n > 0)
        //        {
        //            n--;
        //        }

        //    }
        //    k++;



        //    Console.WriteLine();

        //}

        //for (int i = 1; i <= 5; i++) {
        //    if (i == 1 || i == 5)
        //    {
        //        for (int k = 1; k <= 5; k++)
        //        {
        //            Console.Write("*");
        //        }
        //    }
        //    else {
        //        Console.Write("*");
        //        for (int j = 1; j <= 5-2; j++)
        //        {
        //            Console.Write(" ");
        //        }
        //        Console.Write("*");
        //    }

        //    Console.WriteLine();
        //}




        Console.ReadLine();
    }
}

