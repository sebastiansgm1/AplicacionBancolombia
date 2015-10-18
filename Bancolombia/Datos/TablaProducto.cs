using System;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace Datos
{
    [Table(Name = "TProductos")]

    public class TablaProducto
    {
        [Column(IsPrimaryKey = true)] //Creacion de columna y caracteristicas
        public int NumeroCuenta { get; set; }

        [Column(CanBeNull = false)] 
        public string Usuario { get; set; } //Identificador del usuario

        [Column(CanBeNull = false)]
        public string Producto { get; set; }

        [Column(CanBeNull = false)]
        public float Saldo { get; set; }
    }
}
