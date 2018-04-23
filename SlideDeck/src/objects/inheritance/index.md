title: Inheritance and Polymorphism
subtitle: Two Important Principles of OOP
theme: league

## Topics

 - What is Inheritance?
 - What is Polymorphism?
 - Why are these principles essential to Object-Oriented Programming?

## Inheritance
- In object-oriented programing, **inheritance** is a feature that demonstrates the "IS A" relationship between different classes.
- For example, a TIGER is a CAT.
- Inheritance allows a class to have the same states and behaviors as another class.
- Inheritance also allows derived classes to customize that behavior for the sake of specificity.
- For example, all cats EAT, but tigers EAT a certain way.

## Example of a Base Class

```csharp
public class Shape
{
    private int sides;
 
    public Shape()
    {

    }
    public Shape(int sides)
    {
        this.sides = sides;
    }
 
    public int Sides
    {
        get { return this.sides; }
        set { this.sides = value; }
    }
}
```
 

## Derived Classes

- A **derived class** (also called a **child class** or a **subclass**) is any class that inherits from another class.
- To create a derived class, include a colon and the name of the base class.

```csharp
//Example:
public class ChildClass : ParentClass
```


## Example of Derived Class

```csharp
public class Rectangle : Shape
{
    private double area;
 
    public Rectangle(double area)
    {
        this.area = area;
    }
 
    public double Area
    {
        get { return this.area; }
        set { this.area = value; }
    }
}
```

## Your Turn! 

- What are some examples of base classes?
<div class="fragment">
<li>What are some examples of classes that could be derived from those base classes?</li>
</div>

## Members of a Derived Class

- In OOP, the states and behaviors of a class are, all together, called the "members" of that class.
- Let's talk about what makes the members of a derived class different from the members of a base class.

## Constructors 

- A derived class does NOT inherit the constructors of the base class.
- However, the constructors of the base class can still be accessed using the “base” keyword.

```csharp
public ChildClass(int num) : base(“string”)
{
        // body of constructor
}

```
## Base Constructor Example 

```csharp 
public class Rectangle : Shape
{
    private double area;
 
    public Rectangle(double area) : base(4)
    {
        this.area = area;
    }
 
    public double Area
    {
        get { return this.area; }
        set { this.area = value; }
    }
}
```
- By including the `base(4)`, the public `Shape(int sides)` is included and sets sides equal to 4. 


## Access Modifiers in Derived Classes

Let's review access modifiers:
<div class="fragment">
<code>public</code> - can be accessed from every class
</div>
<div class="fragment">
<code>private</code> - can not be accessed from any other class (default for elements of a class)
</div>
<div class="fragment">
<mark><code>protected</code> - can be accessed from its class and all descendent classes</mark>
</div>
<div class="fragment">
<code>internal</code> - can only be accessed from the same assembly (default for classes) → More later.
</div>

## Access Modifiers Example

```csharp
public class Rectangle : Shape
{
    private double area;
 
    public Rectangle(int sides, double area)
    {
        this.Sides = sides;
        this.area = area;
    }
 
    public double Area
    {
        get { return this.area; }
        set { this.area = value; }
    }
}
```
QUESTION: Why do we have to use the property `Sides` in the `Rectangle` class?  
<div class="fragment">ANSWER: The field <code>sides</code> is set to <code>private</code> in the <code>Shape</code> class.</div>
<div class="fragment">QUESTION: What access modifier can be used so the field sides can be accessed by a child class?</div>


## PRACTICE!!

In Visual Studio, open a new project and create a base class and 2 classes that are derived from that base class.
<div class="fragment">Add four fields to your base class.</div>
<div class="fragment">Add two Properties to your class.</div>
<div class="fragment">Add a constructor to your derived class that includes a call to your base class.</div>
<div class="fragment">Add two methods to your derived classes.</div>
<div class="fragment">Add a method to your base class and use it in both of your derived classes.</div>

## Polymorphism

- **Polymorphism** is the ability to redefine methods for derived classes.
- The Greek roots - "poly" for many and "morph" for form - tells us that this principle allows us to have one method take many forms.
- In order to incorporate polymorphism in C#, we need to use the `virtual` and `override` keywords.

## “virtual” keyword

```csharp
public virtual void Clean()
{
	// body of the method
}
```
In order to give the derived classes permission to create their own version of a method, the keyword `virtual` must be included in the method declaration in the base class.

## Example

```csharp
class Appliance
{
	public virtual void Clean()
	{
		// general cleaning instructions
	}
}

```

## “override” keyword

```csharp
public override void Clean()
{
	// body of the method
}
```
When implementing a new version of the method in the derived class, add the keyword `override`. 

## Override Examples

```csharp
class Dishwasher : Appliance
{
	public override void Clean()
	{
	   //specific instructions for how a dishwasher cleans
	}
}
```
```csharp
class WashingMachine : Appliance
{
	public override void Clean()
	{
	   //specific instructions for how a washing machine cleans
	}
}
```

## PRACTICE!!

- Create a new base class.
<div class="fragment"> - Create two derived classes. </div>
<div class="fragment"> - Create a virtual method in the base class. </div>
<div class="fragment"> - Create an override method in each derived class.</div>

## Abstract Classes

- What is an abstract class?
<div class="fragment">
- An abstract class should be used when instances will be created from derived classes only.
</div> 
<div class="fragment">- An abstract class can not be instantiated.</div>
<div class="fragment">- Abstract classes can have abstract, virtual, and normal methods.</div>


## "abstract" keyword

- Use the abstract keyword to denote a class or method that you do not want to be implemented.
<div class="fragment">Abstract methods can only be placed inside of abstract classes.</div>

## Something peculiar about Abstract classes

An abstract method <mark>does NOT</mark> need a body.

In fact, abstract methods usually <mark>do NOT</mark> have a body.


## Example of Abstract Class

```csharp
public abstract class Appliances
{
	public abstract void Clean();
	// an abstract method does not 
	// have a body
}
```
<mark>NOTE:</mark> An appliance is a good example of an abstract class, because you would never just create an "Appliance" object, you would create a type of appliance, like a "Toaster".

## Class Derived from Abstract Class 

```csharp
class Dishwasher : Appliances
{
	public override void Clean()
	{
	   //in the derived class, use the override keyword to rewrite
	   //an abstract method from the base class  
	}
}
```
<div class="fragment">Let me repeat that ... we use the OVERRIDE keyword in the derived class with abstract methods from the base class.</div>

## PRACTICE!!

Create an abstract Furniture class.
- Create fields and/or Properties in the Furniture class that relate to all furniture types.
- Create an abstract method in your Furniture class.
- Create three derived classes of types of furniture.
- Each type of furniture should have three fields and/or Properties.
- Each type of furniture should have its own, non-override method.
- Each type of furniture should also have a method that overrides the abstract method in the Furniture class.
- In your Program class, instantiate an object of each type of furniture.
- Use all methods from all derived classes inside of your Program class.




<style type="text/css">
/* should we move this into the template, or will it break existing slides. Maybe those slides are wrong. */
.reveal h3 {
	font-size: 4.4rem;	
}
</style>