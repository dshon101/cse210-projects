using System;
using assignments_demo;

namespace assignments_demo
{
    public class WritingAssignment : Assignment
    {
        private string _title = "";

        public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
        {
            
            _title = title;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }
        
        public string GetWritingInformation()
        {
            return $"{_title} by {GetStudentName()}";
        }
    }
}