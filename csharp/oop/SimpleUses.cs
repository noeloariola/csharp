// TUPLES
// provide concise syntax to group multiple data elements in a lightweight data structure
// (string name, int level) student = ("Noel", 4);
// Console.WriteLine(student.name);



// ENUMS
// defines a set of constant values.
public enum Orders {
    Shoe, Bag, TShirt
}
[Flags]
public enum Cart {
    Shoe = 1,
    Bag = 2,
    TShirt = 4,
    All = Shoe | Bag | TShirt  // Bitwise OR operator to combine multiple flags
}



// an interface defines a contract that can be implemented by a classes anmd structs; // you define interfaces tp declare capabilities. 
// An interface typically does not provide implementation of the members it defines. // may employ multiple inheritance
interface ISample {
    void DoSomething();
}

interface IExam : ISample {
    void DoSomethingElse();
}

// struct types are simple types whose primary purpose is to store data values.
// structs cant declare a base typ; they implicitly derive from System.ValueType.
// you cant derive other structs type from a struct type.
public struct Point {
    public double X { get; set; } = 0;
    public double Y { get; set; } = 0;

    public Point(double x, double y) {
        X = x;
        Y = y;
    }
}