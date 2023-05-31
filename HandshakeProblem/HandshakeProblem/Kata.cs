using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandshakeProblem
{
    public static class Kata
    {
        public static int GetParticipants(int handshakes)
        {
            if (handshakes <= 0) return 0;
            if (handshakes == 1) return 2;
            double participants = Math.Ceiling((Math.Sqrt(8 * handshakes + 1) - 1) / 2);
            return (int)participants;
        }
    }
}
