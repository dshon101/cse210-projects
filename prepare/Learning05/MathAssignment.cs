using System;
using assignments_demo;

namespace assignments_demo
{
    public class MathAssignment : Assignment
    {
        private string _textbookSection = "";
        private string _problem = "";

        public MathAssignment(string studentName, string topic, string textbookSection, string problem) : base(studentName, topic)
        {
            
            _textbookSection = textbookSection;
            _problem = problem; 
        }

        public string GetTextbookSection()
        {
            return _textbookSection;
        }

        public void SetTextbookSection(string textbookSection)
        {
            _textbookSection = textbookSection;
        }

        public string GetProblem()
        {
            return _problem;
        }

        public void SetProblem(string problem)
        {
            _problem = problem;
        }
        
        public string GetHomeworkList()
        {
            return $"Section {_textbookSection} Problem {_problem}";
        }
    }
}