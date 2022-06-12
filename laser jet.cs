using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanprinter
{
    class laser_jet : printer
    {
        public override void show()
        {
            Console.WriteLine("Laserjet display dimension : 12*12");
        }

        public override void print()
        {
            Console.WriteLine("Laserjet printer printing ...");
        }
    }
}
