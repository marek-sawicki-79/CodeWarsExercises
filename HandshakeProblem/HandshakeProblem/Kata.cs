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
            int k;
            int i;
            for ( i = 0, k = 1; i < handshakes; i += k++) ;
            return k;
        }
    }
}
