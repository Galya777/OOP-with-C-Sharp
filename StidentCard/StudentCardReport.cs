using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCard
{
    //Event Sorce
    public class StudentCardReport
    {
        //publish event Passing
        public event EventHandler Passing;
        private List<Subject> list;

        public StudentCardReport(List<Subject>subjects)
        {
            ListOfSubjects = new List<Subject>(subjects);
        }

        public void ProcessReport()
        {
            
            foreach (var item in ListOfSubjects)
            {
                foreach (var grade in item.Grades)
                {
                    if (grade>75)
                    {
                        Passing?.Invoke(this, item);
                    }
                    else
                    {
                        Console.WriteLine("Not passing: {0}", item.Title);
                    }
                }
            }
        }
        public List<Subject> ListOfSubjects
        {
            get => list;
            set
            {
            }
        }
    }
}
