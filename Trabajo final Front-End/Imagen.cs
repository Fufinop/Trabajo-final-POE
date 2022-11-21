using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using Org.BouncyCastle.Tls;

namespace Trabajo_final_Front_End
{
    class Imagen
    {
        public static MemoryStream byteToImg(byte[] array)
        {
            MemoryStream memorySream = new MemoryStream((byte[]) array);
            memorySream.Seek(0L, SeekOrigin.Begin);
            return memorySream;
        }

        public static byte [] imgToByte(Image img)
        {
            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream, ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }

        //Prueba
    }
}
