//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdoExample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Auto
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public Nullable<System.DateTime> ProductionYear { get; set; }
        public Nullable<int> Price { get; set; }
        public string BodyType { get; set; }
        public string EngineVolume { get; set; }
        public Nullable<bool> CustomsCLeared { get; set; }
        public string Comment { get; set; }
    }
}
