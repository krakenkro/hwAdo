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
    
    public partial class AutoSale
    {
        public System.Guid Id { get; set; }
        public string Brand { get; set; }
        public System.DateTime ProductionYear { get; set; }
        public int Price { get; set; }
        public string BodyType { get; set; }
        public string EngineVolume { get; set; }
        public bool CustomsCleared { get; set; }
        public string Comment { get; set; }
    }
}
