using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passingParameters
{
    internal class refByref
    {
     public   static void Main()
        {
            Employee ahmed = new Employee { Name = "Ahmed" };//https://miro.medium.com/max/1400/1*66pt_pDruUu79-FfM7ndqw.png

            Console.WriteLine(
                $"Before calling RefByRef, ahmed = Employee ({ahmed.Name})");

            RefByRef(ref ahmed);//https://miro.medium.com/max/1400/1*K1vWlw1vUkfG7x6vs0rzGA.png x=x`=>to heap Ahamd

            Console.WriteLine(
                $"After calling RefByRef, ahmed = Employee ({ahmed.Name})");

            Console.ReadLine();
        }
        public static void RefByRef(ref Employee x)
        {
            x.Name = "Tarek";// x = x`=>to heap tarik  https://miro.medium.com/max/1400/1*-tc6Zj4gRWNTLnG94Z7ltQ.png

            x.Name = "Ahmad222";//x = x`=>to heap Ahmad222
            x = new Employee { Name = "Hasan" };//https://miro.medium.com/max/1400/1*yuzoAsDtN6MlMA6WhE8pKA.png
        }
    }
}

