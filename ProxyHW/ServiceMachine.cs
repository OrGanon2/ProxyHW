using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyHW
{
    public class ServiceMachine : IserviceMachine
    {
        private InteriorOffice interiorOffice;

        public ServiceMachine(InteriorOffice interiorOffice)
        {
            this.interiorOffice = interiorOffice;
        }

        public Client client { get; set; }
        public void ChangeAdress()
        {

            Console.WriteLine("Adress has been changed");
        }

        public void changePassword()
        {
            Console.WriteLine("password has been changed");

        }
        
        public void ClientInfo()
        {
            Console.WriteLine("All Client Info");

        }

        public void PassportRenewal()
        {
            Console.WriteLine("Passwort has been Renewed");

        }
    }
}
