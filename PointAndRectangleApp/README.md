Create and build a Class Library project with the following classes:
1. Write a class Point. It has an array of two integer data elements- the x and y coordinates.
Define a full set of constructors (default, general purpose and a copy constructor), set and
get properties for the class data member, as well as a ToString() method.
2. Next, write a class Rectangle. Design it as follows: Rectangle is a Point, which defines the
upper left corner and has a Point that defines the lower right corner of the rectangle.
Define a full set of constructors (default, general purpose and a copy constructor),properties
for the class data members, as well as a ToString() method (reuse the ToString() method
defined for class Point). Write additionally a double Area() method allowing to compute the
area of the Rectangle object.
3. Finally, write a class Parallelepiped. Design it as follows: Parallelepiped is a Rectangle,
which defines the base side of the Parallelepiped and has height that defines the height
of the Parallelepiped . Define a full set of constructors (default, general purpose and a copy
constructor),properties for the class data members, as well as a ToString() method (reuse the
ToString() method defined for class Rectangle). Write override double Area() method
allowing to compute the total area of the Parallelepiped object
Create a new Project with the Console application template, where add a reference to the previously
built Class Library:
• Add an extension method Volume() to class Parallelepiped, allowing to compute its
volume.
• Add an extension method Perimeter() to class Rectangle, allowing to compute its
perimeter.
Using the Main() method test the inheritance hierarchy Point- Rectangle (create two Points, create a
Rectangle by these Points, create a Parallelepiped using the Rectangle and display the area of the
Rectangle and the Parallelepiped objects. Printout the results of the execution of the extension
methods of thus created objects of type Rectangle and Parallelepiped
