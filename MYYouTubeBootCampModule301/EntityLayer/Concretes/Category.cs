using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class Category
    {
        /*
        int CategoryID; // Field

        void Test()
        {
            int CategoryID; // Variable
        }
        */

        public int CategoryId { get; set; } // Property

        public string Name { get; set; }
    }
}
