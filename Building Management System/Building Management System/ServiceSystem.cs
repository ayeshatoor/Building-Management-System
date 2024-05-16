using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Management_System
{
    public class ServiceSystem : IServiceSystem
    {
        private readonly ISecuritySystem _securityService;

        public ServiceSystem(ISecuritySystem securityService)
        {
            _securityService = securityService;
        }

        public void Maintain()
        {
            Console.WriteLine("Maintaining the service system");
            _securityService.Secure();
        }
    }
}
