//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSR_Petrov_Fedyaev.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class VW_MaterialDetails
    {
        public int ID { get; set; }
        public string NameTypeMaterial { get; set; }
        public string NameMaterial { get; set; }
        public decimal Cost { get; set; }
        public Nullable<int> COUNSUPPLIER { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public Nullable<int> QtyAfter { get; set; }
        public Nullable<System.DateTime> DateChange { get; set; }
    }
}
