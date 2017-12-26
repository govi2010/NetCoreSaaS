namespace NetCoreSaaS.Data.Entities.Tenant.POS.Lesson
{
    public class LessonDetails
    {
        public int LessonDetailsID { get; set; }
        public int LessonID { get; set; }
        public int ItemID { get; set; }
        public int TeacherID { get; set; } // Teacher is one type of User (TeacherID=UserId)

        public decimal Fees { get; set; }
        public decimal ExtraFees { get; set; }

        public string Period { get; set; }
        public string ExtraPeriod { get; set; }
        public string LessonNote { get; set; }
    }
}
