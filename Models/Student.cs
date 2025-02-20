namespace QRCodeSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StudentId { get; set; }  // 學號
        public string QRCodeData { get; set; }  // QR Code Base64
    }
}
