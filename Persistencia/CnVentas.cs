using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CnVentas
    {
        CdVentas cdVentas = new CdVentas();
        public bool validarDatos(CeVentas empleado)
        {
            bool Resultado = true;

            if (empleado.Cliente == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Cliente");
            }

            return Resultado;
        }

        public void prueaMysql()
        {
            cdVentas.pruebaConexion();
        }

        public void crearEmpleado(CeEmpleado cE)
        {
            cdVentas.crear(cE);
        }

        public void editarEmpleado(CeEmpleado cE)
        {
            cdVentas.editar(cE);
        }

        public void eliminarEmpleado(CeEmpleado cE)
        {
            cdVentas.eliminar(cE);
        }
        public void eliminarDatos(CeEmpleado cE)
        {
            cdVentas.eliminarDatos(cE);
        }

        public DataSet obtenerDatos()
        {
            return cdVentas.Listar();
        }
    }
}
