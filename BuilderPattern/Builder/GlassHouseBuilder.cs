using BuilderPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public class GlassHouseBuilder : HouseBuilder
    {
        public GlassHouseBuilder()
        {
            House = new House();
        }

        public override void BildWindows()
        {
            House.AddHousePart("Glass Window");
        }

        public override void BuildDoors()
        {
            House.AddHousePart("Glass Door");
        }

        public override void BuildFloor()
        {
            House.AddHousePart("Glass Floor");
        }

        public override void BuildRoof()
        {
            House.AddHousePart("Glass Roof");
        }

        public override void BuildRooms()
        {
            House.AddHousePart("Glass Room");
        }

        public override void BuildOtherParts()
        {
            House.AddHousePart("Glass Others");
        }
    }
}
