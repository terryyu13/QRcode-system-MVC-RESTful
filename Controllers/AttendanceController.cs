using Microsoft.AspNetCore.Mvc;
using QRCodeSystem.Models;
using System.Collections.Generic;

namespace QRCodeSystem.Controllers
{
    [Route("Attendance")]
    public class AttendanceController : Controller
    {
        private static List<string> attendanceRecords = new List<string>();

        [HttpPost("RecordAttendance")]
        public IActionResult RecordAttendance([FromBody] Student student)
        {
            if (string.IsNullOrEmpty(student.StudentId))
            {
                return BadRequest(new { message = "無效的 QR Code" });
            }

            attendanceRecords.Add(student.StudentId);
            return Ok(new { message = $"學員 {student.StudentId} 參與成功！" });
        }
    }
}
