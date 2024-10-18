using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int no = 1221;
        //    int sum = 0;
        //    int temp = no;
        //    while(no > 0)
        //    {
        //        int rev = no % 10;
        //        sum = sum * 10 + rev;
        //        no = no / 10;
        //    }
        //    if(temp == sum)
        //    {
        //        Console.WriteLine("Palindrome");
        //    }
        //    else
        //    {
        //        Console.WriteLine("not palindrome");
        //    }
        //}
    }
}
/*dry run
  temp, no = 1221;
sum = 0;
no > 0   rev no   sum           no=no/10
 1221>0  1         1            1221/10=122
 122>0   2        1*10+2=12    122/10=12
 12>0    2      12*10+2=122   12/10=1
 1>0     1      122*10+2=1221  1/10=0
    conditon false loop end
*/