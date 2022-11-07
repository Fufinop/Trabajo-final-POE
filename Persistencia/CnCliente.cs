using Controladores;
using Modelos;
using System;
using System.Windows.Forms;

namespace Persistencia
{
    public class CnCliente
    {
        CdCliente cdCliente = new CdCliente();
        public bool validarDatos(CeCliente cliente)
        {
            bool Resultado = true;

            if (cliente.Nombre == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El nombre es obligatorio");
            } if (cliente.Apellidos == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("Los apellidos son obligatorios");
            } if (cliente.Cedula == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("La cedula es obligatoria");
            } if (cliente.Telefono == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El telefono es obligatorio");
            } if (cliente.Email == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Email es obligatorio");
            } if (cliente.Estatus == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El estatus es obligatorio");
            } if (cliente.Foto == null)
            {
                Resultado = false;
                MessageBox.Show("La foto es obligatoria");
            } if (cliente.Direccion == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("La direccion es obligatoria");
            } if (cliente.Id == 0)
            {
                Resultado = false;
                MessageBox.Show("El id debe de ser diferente de cero");
            }


            return Resultado;
        }

        public void prueaMysql()
        {
            cdCliente.pruebaConexion();
        }
    }
}