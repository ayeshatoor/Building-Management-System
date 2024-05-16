using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Management_System
{
    public class SecuritySystem : ISecuritySystem
    {
        public void Secure()
        {
            Console.WriteLine("Securing the building");
        }
    }
}
