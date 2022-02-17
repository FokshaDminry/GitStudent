using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfece_Test_2
{
    class Sale
    {
        public string NameProduct { get; set; }
        public string NameManager { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"Name: {NameProduct}\nManager: {NameManager}\nPrice: {Price}\nDate: {Date}\n";
        }
    }
}
