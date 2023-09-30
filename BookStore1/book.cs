using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore1
{
    internal class book
    {
        public int id {  get; set; }
        public string title { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }

        public override string ToString()
        {
            return $"{id}: {title}: {quantity}: {price}$";
        }
    }
}
