using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyHW
{
    public class InteriorOffice : IFullOption, IserviceMachine
    {
        public void AddClient()
        {
            Console.WriteLine("New client Added Successfuly");
        }

        public void ChangeAdress()
        {

            Console.WriteLine("Adress Has been Changed");
        }

        public void changePassword()
        {
            Console.WriteLine("Password Changed Successfuly Please Relogin");
        }

        public void ClientInfo()
        {
            Console.WriteLine("All Client info");
        }

        public void Info()
        {
            Console.WriteLine("ALL info");
        }

        public void PassportRenewal()
        {
            Console.WriteLine("Password as has been renewed");
        }

        public void RemoveClient()
        {
            Console.WriteLine("Client has been Removed");
        }

        public void ShowAllClient()
        {

            Console.WriteLine("Show ALL clients DataBase");
        }
    }
}
