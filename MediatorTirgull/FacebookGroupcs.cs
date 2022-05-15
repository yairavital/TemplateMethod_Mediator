using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTirgull
{
    internal class FacebookGroupcs:IGroup
    {
        private List<Member> members;
        public FacebookGroupcs()
        {
            members = new List<Member>();
        }

        public void AddMember(Member member)
        {
            members.Add(member);
        }

        public void Send(string message, Member membSend)
        {

            members.ForEach(memb => { if (memb != membSend) memb.Recieve(message); });
        }
    }
}
