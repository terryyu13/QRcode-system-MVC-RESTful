using Microsoft.AspNetCore.Mvc;
using QRCoder;

namespace QRCodeSystem.Controllers
{
    public class QRCodeController : Controller
    {
        public IActionResult GenerateQRCode(string studentId)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(studentId, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qrCode.GetGraphic(20);

            string base64String = Convert.ToBase64String(qrCodeBytes);
            return Json(new { qrCode = "data:image/png;base64," + base64String });
        }
    }
}
