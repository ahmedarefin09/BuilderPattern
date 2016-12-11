using BuilderPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        public void Construct(HouseBuilder builder)
        {
            builder.BuildFloor();
            builder.BuildRooms();
            builder.BuildRoof();
            builder.BuildDoors();
            builder.BildWindows();
            builder.BuildOtherParts();

        }
    }
}
