namespace Entidad
{
    public class CeInventario
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public byte[] Foto { get; set; }
        public string Estatus { get; set; }
    }
}
