using BuilderPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            HouseBuilder brickHouseBuilder = new BrickHouseBuilder();
            HouseBuilder glassHouseBuilder = new GlassHouseBuilder();

            director.Construct(brickHouseBuilder);
            director.Construct(glassHouseBuilder);

            brickHouseBuilder.House.ShowHouse();
            glassHouseBuilder.House.ShowHouse();
        }
    }
}
