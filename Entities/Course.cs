namespace TutorialEUSchool.Entities
{
    public class Course
    {
        // Id of the course, primary id of the database table
        public int CourseID { get; set; }
        // title of the course
        public string Title { get; set; }
        // number of hours of the course
        public int Hours { get; set; }

    }
}
