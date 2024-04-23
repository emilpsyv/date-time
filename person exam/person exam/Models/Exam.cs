using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_exam.Models
{
    internal class Exam
    {
        public string Subject { get; set; }
        public int ExamDuration { get; set; }
        public  DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Exam(string subject , int examDuration,DateTime start)
        {
            Subject = subject;
            ExamDuration = examDuration;
            StartDate = start;
            EndDate = start.AddMinutes(examDuration); 
            
        }
        public void Start () 
        {
            StartDate =  DateTime.Now;
        }
    }
}
