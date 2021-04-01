using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAttendance.model
{
    class Attendance
    {

        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public int RoomId { get; set; }
        public String StartTime { get; set; }
        public String LeaveTime { get; set; }
        public String Comment { get; set; }

        public Attendance(int teacherId, int courseId, int RoomId, string startTime, string leaveTime, string comment ) {
            this.TeacherId = teacherId;
            this.CourseId = courseId;
            this.RoomId = RoomId;
            this.StartTime = startTime;
            this.LeaveTime = leaveTime;
            this.Comment = comment;
        }

    }
}
