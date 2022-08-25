using MusicalInstrument.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrument.Entities
{
    class Drums : Instrument
    {
        public string Title { get; set; }
        public override void Sound()
        {
            Title = "title of Drums";
            Model = "any Drums model";
            Brand = "any Drums brand";
            Price = 333;
        }
    }
}
