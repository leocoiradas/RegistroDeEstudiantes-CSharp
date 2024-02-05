using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    /*public class Conexion: DataConnection
    {
        public Conexion(): base("Estudiantes"){}
        public ITable<Estudiante> _Estudiante { get { return GetTable<Estudiante>(); } }
    }*/
    public class Conexion : DataConnection
    {
        public Conexion() : base("Estudiantes") { }

        public ITable<Estudiante> Estudiantes => this.GetTable<Estudiante>();
    }
}
