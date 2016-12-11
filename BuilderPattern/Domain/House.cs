using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Domain
{
    public class House
    {
        private List<string> _houseParts = new List<string>();
        public void AddHousePart(string housePart)
        {
            _houseParts.Add(housePart);
        }
        public List<string> GetHousePart(string housePart)
        {
            return _houseParts;
        }

        public void ShowHouse()
        {
            Console.WriteLine("----- Showing House ------");
            _houseParts.ForEach(part =>
            {
                Console.WriteLine(part);
            });
            Console.WriteLine("----- End of showing House ------");
        }


    }
}
