using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCard
{
    //Event object
    public class Subject:EventArgs
    {
        private int[] grades;
        public const int MAX_GRADES = 5;

        public Subject(int[] grades, string title)
        {
            this.grades = grades;
            this.Title = title;
            //not required for event objects
            //Grades = grades;
            //Title = title;
        }

        public int[] Grades
        {
            get
            {
                return grades;
                //int[] copy = new int[grades.Length];
                //for (int i = 0; i < grades.Length; i++)
                //{
                //    copy[i] = grades[i];
                //}
                //return copy;
            }
            set
            {
                if(value!=null && value.Length == MAX_GRADES)
                {
                    grades = new int[MAX_GRADES];
                    for (int i = 0; i < value.Length; i++)
                    {
                        grades[i] = value[i];
                    }
                }
                else
                {
                    grades = new int[MAX_GRADES];
                }
            }
        }

        public string Title
        {
            get => default;
            set
            {
            }
        }

        public override string ToString()
        => $"Grades{string.Join(", ", grades)}";
    }
}
