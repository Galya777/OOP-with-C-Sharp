Write an application that handles a student report card. The application shall save the marks of
Computer Science, Math and English. Each Subject has a Title and an array grades of
MAX_GRADES elements, where each element represents a grade in the interval [0, 150] marks. If a
student obtains at least 75 of the 150 marks per grade, an event named Passing will trigger and
show a congratulation message on passing the exam. Otherwise, the application displays a message
for assigning an “F” grade.
Use EventHandler to define the event Passing, where class Subject shall represent the event
object and class StudentGradeReport represents the event source. Use method ProcessReport
in class StudentGradeReport to browse List<Subject> ListOfSubjects elements and
trigger event Passing once an element of array grades in a Subject is above 75 .Use the public
static void Main() method in class Program to instantiate the event source. Write method
OnPassing in class Program for handling the event Passing of the event source and subscribe for
the event Passing published by the event source using this method.
Create a List<Subject> with Random values for the elements of array grades in each Subject to
test handling of the event Passing.
