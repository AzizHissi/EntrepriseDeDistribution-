//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntrepriseDeDistribution
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public int Numero_Livre { get; set; }
        public int Numero_Editeur { get; set; }
        public int Numero_Depot { get; set; }
        public Nullable<int> Quantite { get; set; }
    
        public virtual Depot Depot { get; set; }
        public virtual Editeur Editeur { get; set; }
        public virtual Livre Livre { get; set; }
    }
}
