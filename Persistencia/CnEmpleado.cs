using Controladores;
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
        public bool validarDatos(CeEmpleado cliente)
        {
            bool Resultado = true;

            if (cliente.Nombre == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El nombre es obligatorio");
            }
            if (cliente.Id == 0)
            {
                Resultado = false;
                MessageBox.Show("El id debe de ser diferente de cero");
            }
            if (cliente.Apellidos == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El apellido es obligatorio");
            }
            if (cliente.Salario == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El salario no puede estar vacio");
            }
            if (cliente.Tipo == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El tipo es obligatorio");
            }
            if (cliente.Estatus == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El estatus es obligatorio");
            }
            if (cliente.Foto == null)
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

        public void crearCliente(CeEmpleado cE)
        {
            cdEmpleado.crear(cE);
        }

        public void editarCliente(CeEmpleado cE)
        {
            cdEmpleado.editar(cE);
        }

        public void eliminarCliente(CeEmpleado cE)
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
