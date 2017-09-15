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
                Byte[] data;
                using (var memoryStream = new MemoryStream())
                {
                    bitMap.Save(memoryStream, ImageFormat.Bmp);

                    data = memoryStream.ToArray();
                }
                return base.File(data, "image/bmp");
            }
        }
    }
}