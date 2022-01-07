using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCard
{
    //The subscriber
    class Program
    {
        enum Subjects { CS, ENG, MATH};
        public static void Main(string[] args)
        {
            List<Subject> list = new List<Subject>();
                string[] titles = { "CS", "ENGLISH", "MATH" };
            Random r = new Random();
            for (int i = 0; i < titles.Length; i++)
            {
              int[] grades = new int[Subject.MAX_GRADES];
                for (int j = 0; j< grades.Length; j++)
                {
                    grades[i] = r.Next(0, 151);
                }
                Subject subject = new Subject( grades, titles[i]);
                list.Add(subject);
            }
            StudentCardReport report = new StudentCardReport(list);
            report.Passing += OnPassing; //subscribe
            report.ProcessReport();//fire event
        }

        public static void OnPassing(object obj, EventArgs eventArgs)
        {
            Subject subject = (Subject)eventArgs;
            Console.WriteLine($"Passing: {subject.Title}");
            throw new System.NotImplementedException();
        }
    }
}
