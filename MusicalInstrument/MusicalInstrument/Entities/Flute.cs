using MusicalInstrument.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrument.Entities
{
    class Flute : Instrument
    {
        public double Height { get; set; }
        public override void Sound()
        {
            Height = 30;
            Model = "any Flute model";
            Brand = "any Flute brand";
            Price = 555;
        }
    }
}
