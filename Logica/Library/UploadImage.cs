using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class UploadImage
    {
        private OpenFileDialog fd = new OpenFileDialog();
        public void LoadImage(PictureBox pictureBox)
        {
            pictureBox.WaitOnLoad = true;
            fd.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp";
            fd.ShowDialog();
            if (fd.FileName != string.Empty)
            {
                pictureBox.ImageLocation = fd.FileName;
            }

        }
        public byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));   
        }
    }
}
