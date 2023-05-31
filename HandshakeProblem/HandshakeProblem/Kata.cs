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
            //if (handshakes <= 0) return 0;
            //int k;
            //int i;
            //for ( i = 0, k = 1; i < handshakes; i += k++) ;
            //return k;
            return handshakes == 0 ? 0 : (int)Math.Ceiling((1 + Math.Sqrt(1 + 8 * handshakes)) / 2.0);
        }
    }
}
