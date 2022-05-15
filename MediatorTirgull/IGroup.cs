using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTirgull
{
    internal interface IGroup
    {
        void Send(string message, Member member);
        void AddMember(Member member);
    }
}
