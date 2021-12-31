Create a struct Point which has coordinates (double x, double y, double z).
Create a struct Vector which has a starting Point and an end Point.
Create a struct Triangle which has sides Vector a and Vector b.
Add default implementations of methods Equals() and GetHashCode() in these structs
Define an interface Comparable and implement it with explicit name qualification in structs
Point, Vector and Triangle.
Include in interface Comparable the following:
- -method double SizeOf();
// the SizeOf() a Point is the absolute value of the total of its coordinates
// the SizeOf() a Vector is the length of the Vector
// the SizeOf() a Triangle is the absolute value of its area
- an indexer get and set property using a string to access the datamemebers
of Point, Vector and Triangle
Provide general purpose constructor for the above structs and override the inherited
ToString() method that displays the data members and the SizeOf() the respective object
(properly formatted with 2 digits after the decimal point). Override method Equals() inherited from
class object.
Define a public delegate
bool GreaterThan(Comparable obj1, Comparable obj2) // obj1 is greater than obj2
to compare Comparable objects in terms of SizeOf();
For each of the structs Point, Vector and Triangle define a private static method
GetSizeOf(Comparable obj1, Comparable obj2) to implement the delegate GreaterThan
for the respective struct. Return true when obj1.SizeOf() is greater than obj2.SizeOf()and
false otherwise.
Define a static get property returning the instance of GreaterThan for GetSizeOf().
For structs Vector and Triangle overload the operators :
a) operator +
For struct Vector- add the coordinates of the two vectors in addition; For struct Triangle- add
the areas of the Triangles in addition
b) operator *
For struct Vector- the vector product of two vectors in multiplication; as well as, the product
of a Vector by an Integer number. For Triangle- a product of a Triangle and an integer
number (zoom factor)- each of the Vector sides of the Triangle are multiplied by the zoom
factor
Define a BubbleSort( Comparable[],GreaterThan g) method to sort an array of
Comparable objects, where the delegate GreaterThan determines the ordering sequence (Assume
the elements of Comparable[] are all Points, Vectors or Triangles only)
Write a Windows application that defines Points, Vectors, and Triangles and sorts them by
clicking respective buttons, adds Vector objects, adds Triangle objects and zooms Triangle
objects by a user defined factor
