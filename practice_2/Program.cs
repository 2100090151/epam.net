using System;
using System.Collections.Generic;
using System.Linq;

// 1) Access Modifiers (public, private, protected, internal)
public class AccessModifiersExample
{
    public int PublicVariable;
    private int PrivateVariable;
    protected int ProtectedVariable;
    internal int InternalVariable;
}

// 2) Use of set and get accessors
public class GetterSetterExample
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}

// 3) Encapsulation and Abstraction
public class EncapsulationExample
{
    private int _age;

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
}

// 4) Inheritance
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

// 5) Polymorphism (compile-time, run-time)
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

// 6) Virtual, override keywords
public class BaseClass
{
    public virtual void Method()
    {
        Console.WriteLine("Base class method.");
    }
}

public class DerivedClass : BaseClass
{
    public override void Method()
    {
        Console.WriteLine("Derived class method.");
    }
}

// 7) Constructors-destructors
public class ConstructorDestructorExample
{
    public ConstructorDestructorExample()
    {
        Console.WriteLine("Constructor called.");
    }

    ~ConstructorDestructorExample()
    {
        Console.WriteLine("Destructor called.");
    }
}

// 8) Sealed keyword
public sealed class SealedClass
{
    public void Method()
    {
        Console.WriteLine("Sealed class method.");
    }
}

// 9) Abstract classes and methods
public abstract class AbstractClass
{
    public abstract void AbstractMethod();
}

// 10) Multiple inheritance using interface
public interface IInterface1
{
    void Method1();
}

public interface IInterface2
{
    void Method2();
}

public class MultipleInheritanceExample : IInterface1, IInterface2
{
    public void Method1()
    {
        Console.WriteLine("Method1 from Interface1.");
    }

    public void Method2()
    {
        Console.WriteLine("Method2 from Interface2.");
    }
}

// 11) Delegates
public delegate void MyDelegate();

// 12) Events
public class EventPublisher
{
    public event MyDelegate MyEvent;

    public void RaiseEvent()
    {
        MyEvent?.Invoke();
    }
}

// 13) Collections
// Example: List<T>, Dictionary<TKey, TValue>, etc.

// 14) Generics
public class GenericClass<T>
{
    public T Data { get; set; }
}

// 15) IEnumerable
public class EnumerableExample : IEnumerable<int>
{
    private List<int> _data = new List<int>();

    public void Add(int item)
    {
        _data.Add(item);
    }

    public IEnumerator<int> GetEnumerator()
    {
        return _data.GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return _data.GetEnumerator();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage of each concept
        Console.WriteLine("1) Access Modifiers:");
        var accessModifiersExample = new AccessModifiersExample();
        accessModifiersExample.PublicVariable = 10;

        Console.WriteLine("2) Use of Set and Get Accessors:");
        var getterSetterExample = new GetterSetterExample();
        getterSetterExample.Name = "John";

        Console.WriteLine("3) Encapsulation and Abstraction:");
        var encapsulationExample = new EncapsulationExample();
        encapsulationExample.Age = 25;

        Console.WriteLine("4) Inheritance:");
        var dog = new Dog();
        dog.Eat();
        dog.Bark();

        Console.WriteLine("5) Polymorphism:");
        Shape shape = new Circle();
        shape.Draw();

        Console.WriteLine("6) Virtual, Override Keywords:");
        var derivedClass = new DerivedClass();
        derivedClass.Method();

        Console.WriteLine("7) Constructors-Destructors:");
        var constructorDestructorExample = new ConstructorDestructorExample();

        Console.WriteLine("8) Sealed Keyword:");
        var sealedClass = new SealedClass();
        sealedClass.Method();

        Console.WriteLine("9) Abstract Classes and Methods:");
        // AbstractClass abstractClass = new AbstractClass(); // Cannot instantiate abstract class

        Console.WriteLine("10) Multiple Inheritance using Interface:");
        var multipleInheritanceExample = new MultipleInheritanceExample();
        multipleInheritanceExample.Method1();
        multipleInheritanceExample.Method2();

        Console.WriteLine("11) Delegates:");
        MyDelegate myDelegate = delegate () { Console.WriteLine("Delegate method."); };
        myDelegate();

        Console.WriteLine("12) Events:");
        var eventPublisher = new EventPublisher();
        eventPublisher.MyEvent += () => Console.WriteLine("Event handled.");
        eventPublisher.RaiseEvent();

        Console.WriteLine("13) Collections:");
        var list = new List<int> { 1, 2, 3, 4, 5 };
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("14) Generics:");
        var genericClass = new GenericClass<string>();
        genericClass.Data = "Hello";
        Console.WriteLine(genericClass.Data);

        Console.WriteLine("15) IEnumerable:");
        var enumerableExample = new EnumerableExample();
        enumerableExample.Add(1);
        enumerableExample.Add(2);
        enumerableExample.Add(3);
        foreach (var item in enumerableExample)
        {
            Console.WriteLine(item);
        }
    }
}
