Use Explicit Interface Member Name Qualification to implement interfaces in the following
problems:
A) Define an interface IConvertible that indicates that the class can convert a
string to C# or VB2015. The interface should have two methods: ConvertToCSharp
and ConvertToVB2015. Each method should take a string, and return a string.
B) Implement that interface and test it by creating a class ProgramHelper that
implements IConvertible. You can use simple string messages to simulate the
conversion.
C) Extend the interface IConvertible by creating a new interface, ICodeChecker. The
new interface should implement one new method, CodeCheckSyntax, which takes two
strings: the string to check, and the language to use. The method should return a bool.
Revise the ProgramHelper class from Problem B to use the new interface.
D) Demonstrate the use of is and as. Create a new class, ProgramConverter, that
implements IConvertible. ProgramConverter should implement the
ConvertToC-Sharp( ) and ConvertToVB( ) methods.
E) Revise ProgramHelper so that it derives from ProgramConverter, and implements
ICodeChecker.
