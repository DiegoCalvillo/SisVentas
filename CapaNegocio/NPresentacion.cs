using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NPresentacion
    {
        //Metodo que llame al metodo Insertar de la clase DPresentacion de la CapaDatos
        public static string Insertar(string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        //Metodo que llame al metodo Editar de la clase DPresentacion de la CapaDatos
        public static string Editar(int idpresentacion, string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.IdPresentacion = idpresentacion;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }

        //Metodo que llame al metodo Eliminar de la clase DPresentacion de la CapaDatos
        public static string Eliminar(int idpresentacion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.IdPresentacion = idpresentacion;
            return Obj.Eliminar(Obj);
        }

        //Metodo que llame al metodo Mostrar de la clase DPresentacion de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DPresentacion().Mostrar();
        }

        //Metodo que llame al metodo BuscarNombre de la clase DPresentacion de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
