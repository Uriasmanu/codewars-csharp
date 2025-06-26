using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class Clock
    {
        public static int Past(int h, int m, int s)
        {
            return (h * 3600 + m * 60 + s) * 1000;
        }
    }
}
