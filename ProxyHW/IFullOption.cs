using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyHW
{
    internal interface IFullOption
    {
        public void AddClient();
        public void RemoveClient();

        public void ShowAllClient();
        public void Info();
    }
   

    
}
