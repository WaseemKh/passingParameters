using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passingParameters
{
    internal class referanceByvalue
    {
        Employee ahmed = new Employee { Name = "Ahmed" };//https://miro.medium.com/max/1400/1*66pt_pDruUu79-FfM7ndqw.png
        public void main()
        {
            Console.WriteLine($"Before calling RefByVal, ahmed = Employee ({ahmed.Name})");
            RefByVal(ahmed); //https://miro.medium.com/max/1400/1*s9wlDCEVAB_uvpHCq4An0g.png
            Console.WriteLine($"After calling RefByVal, ahmed = Employee ({ahmed.Name})");
        }
  
        private static void RefByVal(Employee x)
        {
            x.Name = "Tarek"; https://miro.medium.com/max/1400/1*n7jP0lZ5lSZzhSXp57DNsg.png
            
            //x = new Employee { Name = "Hasan" };//https://miro.medium.com/max/1400/1*zbLEGzmTw2Cqjc52f9368Q.png
            //Console.WriteLine($"in calling RefByVal -new object -, ahmed = Employee ({x.Name})"); //Hasan
        }
    }

    public class Employee
    {
        public string Name { get; set; }
    }
}
