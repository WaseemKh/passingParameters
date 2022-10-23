using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passingParameters
{
    internal class referanceByvalue
    {
        Employee ahmed = new Employee { Name = "Ahmed" };//https://miro.medium.com/max/1400/1*K1vWlw1vUkfG7x6vs0rzGA.png
        public void main()
        {
            Console.WriteLine($"Before calling RefByVal, ahmed = Employee ({ahmed.Name})");
            RefByVal(ahmed); //https://miro.medium.com/max/1400/1*s9wlDCEVAB_uvpHCq4An0g.png
            Console.WriteLine($"After calling RefByVal, ahmed = Employee ({ahmed.Name})");
        }
  
        private static void RefByVal(Employee x)
        {
            x.Name = "Tarek"; https://miro.medium.com/max/1400/1*n7jP0lZ5lSZzhSXp57DNsg.png
            x = new Employee { Name = "Hasan" };//https://miro.medium.com/max/1400/1*zbLEGzmTw2Cqjc52f9368Q.png
        }
    }

    public class Employee
    {
        public string Name { get; set; }
    }
}
