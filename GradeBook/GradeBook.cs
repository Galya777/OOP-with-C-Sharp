// Fig. 4.12: GradeBook.cs
// GradeBook class with a constructor to initialize the course name.
using System;

public class GradeBook
{
    private string instructor;
   private string courseName; // course name for this GradeBook
    private int currentYear;
   // constructor initializes courseName with string supplied as argument
   public GradeBook( string Instname, string Coursename)
   {
        instructor = Instname;
      CourseName = Coursename; // initialize courseName using property
   } // end constructor

   // property to get and set the course name
   public string CourseName
   {
      get
      {
         return courseName;
      } // end get
      set
      {
         courseName = value;
      } // end set
   } // end property CourseName
    public string GetInstructor()
    { return name; }
    public void SetInstructor(string value)
    { instructor = value; }     // display a welcome message to the GradeBook user
    public int CourseStart { get { return currentYear; }  }
    public void DisplayMessage()
   {
      // use property CourseName to get the 
      // name of the course that this GradeBook represents
      Console.WriteLine( "Welcome to the grade book for\n{0}!",
         CourseName );
        Console.WriteLine("\nThis course is presented by: ", instructor);
   } // end method DisplayMessage
    public override GradeBookTitle()
    {
        return string.Format($"The instructor is: {instructor}" + $"His couse is: {courseName}\n" +
            $"And starts: {CourseStart}");
    }
} // end class GradeBook


