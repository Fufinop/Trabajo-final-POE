﻿using Controladores;
using Datos;
using Entidad;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CnEmpleado
    {
        CdEmpleado cdEmpleado = new CdEmpleado();
        public bool validarDatos(CeEmpleado empleado)
        {
            bool Resultado = true;

            if (empleado.Nombre == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El nombre es obligatorio");
            }
            if (empleado.Apellidos == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El apellido es obligatorio");
            }
            if (empleado.Salario == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El salario no puede estar vacio");
            }
            if (empleado.Tipo == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El tipo es obligatorio");
            }
            if (empleado.Foto == null)
            {
                Resultado = false;
                MessageBox.Show("La foto es obligatoria");
            }

            return Resultado;
        }

        public void prueaMysql()
        {
            cdEmpleado.pruebaConexion();
        }

        public void crearEmpleado(CeEmpleado cE)
        {
            cdEmpleado.crear(cE);
        }

        public void editarEmpleado(CeEmpleado cE)
        {
            cdEmpleado.editar(cE);
        }

        public void eliminarEmpleado(CeEmpleado cE)
        {
            cdEmpleado.eliminar(cE);
        }
        public void eliminarDatos(CeEmpleado cE)
        {
            cdEmpleado.eliminarDatos(cE);
        }

        public DataSet obtenerDatos()
        {
            return cdEmpleado.Listar();
        }
    }
}
