using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp220623_02
{
    class Product
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public override string ToString()
        {
            return Name + " : " + Price + "원";
        }

    }
}
