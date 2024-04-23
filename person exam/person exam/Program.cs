using person_exam.Models;
using System.ComponentModel;
using System.Threading.Channels;

namespace person_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Person samir = new Person("samir","kentovskiy",19);
            //Person samire = new Person("samire","kentovskaya",19);
            //Person qarib = new Person("qarib","yapon",21);
            //Person elxan = new Person("ali","alika",19);
            //List<Person> People = new List<Person>();
            //People.Add(samir);
            //People.Add(qarib);
            //People.Add(elxan);
            //People.Add(samire);
            //People.FindAll(s=> s.Name.ToLower()=="samir").ForEach(s=>Console.WriteLine(s.Age+" "+s.Name+" "+s.Surname));
            //Console.WriteLine(" ");
            //People.FindAll(s => s.Surname.ToLower().Contains("kiy") |  s.Surname.ToLower().Contains("kaya")).ForEach(s=>Console.WriteLine(s.Age+" "+s.Name+" "+s.Surname));
            //Console.WriteLine(" ");
            //People.FindAll(s=> s.Age>20).ForEach(s=>Console.WriteLine(s.Age+" "+s.Name+" "+s.Surname));

            DateTime dateTime = DateTime.Now;
            DateTime Time1 = new DateTime(2024, 05, 24);
            DateTime Time2 = new DateTime(2023,06,12);
            List<Exam> exams = new List<Exam>();
            Exam exam = new Exam("code exam", 300, DateTime.Now);exam.Start();
            Exam exam1 = new Exam("uni exam", 90, DateTime.Today);
            Exam exam2 = new Exam("school exam", 45, Time1);
            Exam exam3 = new Exam("life exam", 9999, DateTime.Now);
            Exam exam4 = new Exam("english", 121, DateTime.Today);
            exams.Add(exam);
            exams.Add(exam1);
            exams.Add(exam2);
            exams.Add(exam3);
            exams.Add(exam4);
            
            Console.WriteLine("son 1 hefte");
            exams.FindAll(s => s.StartDate <= dateTime.AddDays(7)).ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuration));
            Console.WriteLine("2 saatdan uzun");
            exams.FindAll(s => s.ExamDuration > 120).ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuration));
            Console.WriteLine("basliyib bitmeyen");
            exams.FindAll(s=>dateTime>=s.StartDate && dateTime<s.EndDate).ForEach(s => Console.WriteLine(s.Subject));

            


        }
    }
}
