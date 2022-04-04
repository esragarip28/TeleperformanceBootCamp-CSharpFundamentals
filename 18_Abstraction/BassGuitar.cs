using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Abstraction
{
    class BassGuitar : Guitar
    {
        public override void Play()
        {
            Console.WriteLine("Bass guitar is playing");
        }
    }
}
