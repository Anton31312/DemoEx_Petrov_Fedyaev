using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSR_Petrov_Fedyaev.EF
{
    public partial class Material
    {

        public string SupplierList
        {

            get
            {
                return string.Join(",", Supplier);
            }

        }
    }
}
