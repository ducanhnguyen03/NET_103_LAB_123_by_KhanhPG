using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_103_LAB_123.Models
{
    [Serializable]
    internal class Cars
    {
        public string NameCar { get; set; }

        public string Producer { get; set; }

        public int Price { get; set; }

        public int Stocks { get; set; }

        public Cars()
        {

        }
    }
}
