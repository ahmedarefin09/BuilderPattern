using BuilderPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public class BrickHouseBuilder : HouseBuilder
    {
        public BrickHouseBuilder()
        {
            House = new House();
        }
        
        public override void BildWindows()
        {
            House.AddHousePart("Brick Window");
        }

        public override void BuildDoors()
        {
            House.AddHousePart("Brick Door");
        }

        public override void BuildFloor()
        {
            House.AddHousePart("Brick Floor");
        }

        public override void BuildRoof()
        {
            House.AddHousePart("Brick Roof");
        }

        public override void BuildRooms()
        {
            House.AddHousePart("Brick Room");
        }

        public override void BuildOtherParts()
        {
            House.AddHousePart("Brick Others");
        }
    }
}
