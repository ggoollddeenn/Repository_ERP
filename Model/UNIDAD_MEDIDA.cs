//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UNIDAD_MEDIDA
    {
        public UNIDAD_MEDIDA()
        {
            this.ARTICULO = new HashSet<ARTICULO>();
        }
    
        public int ID_UNIDAD_MEDIDA { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<System.DateTime> FECHA_CREACION { get; set; }
        public Nullable<int> ID_USUARIO_CREACION { get; set; }
        public Nullable<System.DateTime> FECHA_ACTUALIZACION { get; set; }
        public Nullable<int> ID_USUARIO_ACTUZALICION { get; set; }
    
        public virtual ICollection<ARTICULO> ARTICULO { get; set; }
    }
}
