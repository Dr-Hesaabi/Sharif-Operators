using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace Andycabar.Controllers
{
    public class QrController : Controller
    {
        /*
        public static byte[] BitmapToByteArray(Bitmap bitmap)
        {

            BitmapData bmpdata = null;

            try
            {
                bmpdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
                int numbytes = bmpdata.Stride * bitmap.Height;
                byte[] bytedata = new byte[numbytes];
                IntPtr ptr = bmpdata.Scan0;

                Marshal.Copy(ptr, bytedata, 0, numbytes);

                return bytedata;
            }
            finally
            {
                if (bmpdata != null)
                    bitmap.UnlockBits(bmpdata);
            }

        }
        */

        // GET: Qr
        [Route("~/Qr/{code}")]
        public FileResult Index(string code = "AndyCaBar")
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode("ACB_" + code, QRCodeGenerator.ECCLevel.Q);
            System.Web.UI.WebControls.Image imgBarCode = new System.Web.UI.WebControls.Image();
            imgBarCode.Height = 150;
            imgBarCode.Width = 150;
            using (Bitmap bitMap = qrCode.GetGraphic(20))
            {
                //using (MemoryStream ms = new MemoryStream())
                //{
                //    bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                //    byte[] byteImage = ms.ToArray();
                //    imgBarCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
                //}
                //plBarCode.Controls.Add(imgBarCode);


                Byte[] data;
                using (var memoryStream = new MemoryStream())
                {
                    bitMap.Save(memoryStream, ImageFormat.Bmp);

                    data = memoryStream.ToArray();
                }
                return base.File(data, "image/bmp");
            }

            //return View();
        }
    }
}