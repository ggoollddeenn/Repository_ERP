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
    
    public partial class ARTICULO
    {
        public ARTICULO()
        {
            this.IMPUESTO_ARTICULO = new HashSet<IMPUESTO_ARTICULO>();
            this.VENTA_DETALLE = new HashSet<VENTA_DETALLE>();
            this.CODIGO_ARTICULO = new HashSet<CODIGO_ARTICULO>();
        }
    
        public int ID_ARTICULO { get; set; }
        public int ID_LINEA { get; set; }
        public int ID_ESTATUS_ARTICULO { get; set; }
        public Nullable<int> ID_UNIDAD_MEDIDA { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public string FABRICANTE { get; set; }
        public string IMAGEN { get; set; }
        public int TIENE_CADUCIDAD { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public int ID_USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_ACTUALIZACION { get; set; }
        public int ID_USUARIO_ACTUALIZACION { get; set; }
    
        public virtual UNIDAD_MEDIDA UNIDAD_MEDIDA { get; set; }
        public virtual ESTATUS_ARTICULO ESTATUS_ARTICULO { get; set; }
        public virtual ICollection<IMPUESTO_ARTICULO> IMPUESTO_ARTICULO { get; set; }
        public virtual LINEA LINEA { get; set; }
        public virtual ICollection<VENTA_DETALLE> VENTA_DETALLE { get; set; }
        public virtual ICollection<CODIGO_ARTICULO> CODIGO_ARTICULO { get; set; }
    }
}