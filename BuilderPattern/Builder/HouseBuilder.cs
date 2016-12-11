using BuilderPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public abstract class HouseBuilder
    {
        public House House { get; set; }
        public abstract void BuildFloor();
        public abstract void BuildRooms();
        public abstract void BuildRoof();
        public abstract void BildWindows();
        public abstract void BuildDoors();
        public abstract void BuildOtherParts();

    }
}
