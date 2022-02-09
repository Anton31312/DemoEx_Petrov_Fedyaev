using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSR_Petrov_Fedyaev.EF
{
    public class MaterialClass
    {
        public int ID { get; set; }
        public string NameMaterial { get; set; }
        public int IDTypeMaterial { get; set; }
        public string Image { get; set; }
        public decimal Cost { get; set; }
        public int Qty { get; set; }
        public int MinQty { get; set; }
        public int QtyInPackage { get; set; }
        public int IDUnit { get; set; }
        public string Description { get; set; }
    }
}
