using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTirgull
{
    internal class Member : IMember
    {
        private FacebookGroupcs facebookGroupcs;
        public string Name { get; set; }    

        public Member(FacebookGroupcs facebookGroupcs, string name)
        {
            this.facebookGroupcs = facebookGroupcs;
            Name = name;
        }

        public void Publish(string message)
        {
            facebookGroupcs.Send(message, this);
        }
        
        public void Recieve(string message)
        {
            Console.WriteLine(message);
        }
    }
}
