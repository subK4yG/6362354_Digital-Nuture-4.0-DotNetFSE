namespace MVCPatternExample
{
    public class StudentController
    {
        private Student student;
        private StudentView view;
        public StudentController(Student student, StudentView view)
        {
            this.student = student;
            this.view = view;
        }
        public void SetName(string name) => student.Name = name;
        public void SetId(string id) => student.Id = id;
        public void SetGrade(string grade) => student.Grade = grade;
        public void UpdateView()
        {
            view.DisplayStudentDetails(student.Name, student.Id, student.Grade);
        }
    }
}
