
//  Structure of object-oriented programming

/*  - Classes are user-defined data types that act as the blueprint for individual objects, attributes and methods.

    - Objects are instances of a class created with specifically defined data. Objects can correspond to real-world objects or an abstract entity. 
    When class is defined initially, the description is the only object that is defined.

    - Methods are functions that are defined inside a class that describe the behaviors of an object. 
    Each method contained in class definitions starts with a reference to an instance object. Additionally, 
    the subroutines contained in an object are called instance methods. Programmers use methods for reusability or keeping functionality encapsulated inside one object at a time.

    - Attributes are defined in the class template and represent the state of an object. Objects will have data stored in the attributes field. 
    Class attributes belong to the class itself. */

using OOP;

Console.WriteLine("Main principles of OOP");
Console.WriteLine("Encapsulation");
Encapsulation encapsulation = new Encapsulation();
encapsulation.GetUsernamePassword();