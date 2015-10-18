using System;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace Datos
{
    [Table(Name = "Tusuario")] //Definicion de la clase como tabla

    public class TablaUsuario
    {
        //identificador del usuario
        [Column(IsPrimaryKey = true, IsDbGenerated = true)] //Creacion de columna y caracteristicas
        public int Cuenta { get; set; } // Definicion de columnas y atributos set para definir y get para extraer datos

        [Column(CanBeNull =false)]
        public string NombreUsuario { get; set; }

       /* [Column(CanBeNull =false)]
        public float Saldo { get; set; }*/
    }

}
