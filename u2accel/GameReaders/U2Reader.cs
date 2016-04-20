﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace u2accel
{
    class U2Reader : GameReader
    {
        new public int GameId
        {
            get
            {
                return 1;
            }
        }

        public U2Reader() : base()
        {
            speedAddress = 0x007F09E8;
            name = "speed2";
        }
    }
}
