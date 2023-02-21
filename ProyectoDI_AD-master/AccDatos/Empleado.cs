using System;
using System.Collections.Generic;
using System.Text;

namespace AccDatos
{
    public class Empleado
    {
        //campos privados
        int _idEmpleado;
        string _usuario;
        string _nombre;
        string _apellido;
        string _mail;
        int _tienda;
        //Propiedades publicas
        public int IdEmpleado
        {
            get
            {
                return _idEmpleado;
            }
            set
            {
                _idEmpleado = value;
            }
        }
        public string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }
        public int Tienda
        {
            get
            {
                return _tienda;
            }
            set
            {
                _tienda = value;
            }
        }
        //Constructor(es)
        public Empleado(int idEmpleado, string usuario, int idTienda)
        {
            _idEmpleado = idEmpleado;
            _usuario = usuario;
            _tienda = idTienda;
        }


        //Metodos


    }
}
