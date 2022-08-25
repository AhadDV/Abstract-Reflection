using MusicalInstrument.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrument.Entities
{
     class Piano : Instrument
    {
        public int Octave { get; set; }
        public override void Sound()
        {
            Octave = 4;
            Model = "Any piano";
            Brand = "Kawai";
            Price = 1000;
        }
    }
}
