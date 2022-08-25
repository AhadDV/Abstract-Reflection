using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrument.Abstracts
{
    abstract class Instrument
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }

        public abstract void Sound();
        
    }
}
