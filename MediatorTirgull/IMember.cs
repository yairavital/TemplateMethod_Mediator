using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTirgull
{
    internal interface IMember
    {
        void Publish(string message);
        void Recieve(string message);
    }
}
