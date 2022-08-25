using MusicalInstrument.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrument.Entities
{
    class Gitar : Instrument
    {
        public double Weight { get; set; }
        public override void Sound()
        {
            Weight = 4;
            Model = "any guitar model";
            Brand = "any guitar brand";
            Price = 300;
        }
    }
}
