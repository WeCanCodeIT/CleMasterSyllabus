title: OOP Core Concepts
subtitle: Mmmmm… pie.
theme: league

# A PIE

<p><img src="./resources/apple-pie.jpg" style="max-height: 50rem;"></p>

# What does it stand for?

% TODO ugh this is hacky. use classes to style, padding, etc

<div style="font-size: larger;">
<p><strong class="fragment" style="font-size: larger;">[ A ]</strong> <span class="fragment">bstraction</span></p>
<p><strong class="fragment" style="font-size: larger;">[ P ]</strong> <span class="fragment">olymporphism</span></p>
<p><strong class="fragment" style="font-size: larger;">[ I ]</strong> <span class="fragment">nheritance</span></p>
<p><strong class="fragment" style="font-size: larger;">[ E ]</strong> <span class="fragment">ncapsulation</span></p>
</div>

# Abstraction

We create abstractions to simplify our program domain. They allow us to focus on the problem we are solving rather than getting lost in minute details. *You don't need to know how every subsystem in your car works in order to drive, do you?*

**Think about writing code as the process of creating a language to describe a problem we're solving. Abstractions are the building blocks of this language.**

## In our code

We are creating abstractions in the small whenever we:

- name a variable
- create (and name) a method
- create (and name) a class
- simplify an attribute by representing it as a number (*hunger*) or a label ("purple")

This is why naming is so important: we need to accurately convey the abstraction we're describing to those that follow (as well as our later selves).

We apply the other OO principles (PIE) to create meaningful and useful abstractions of more complex concepts.

# Polymorphism

> the quality or state of existing in or assuming different forms

Polymorphism allows us to represent intent, but allow the implementation to vary as needed based on context.

## In our code

### Method overloading

A method with the same name that accepts different argument types. An overloaded method can have a different return type, but this is usually a *code smell* since its intent should be the same.

Examples:

- `System.out`'s `println` methods (its type is `java.io.PrintStream`)
- `org.junit.Assert`'s numerous `assertEquals` methods 

## In our code

### Method overriding

A method that redefines a method from a superclass is said to *override* that method. A great example of this are the `toString`, `equals`, and `hashCode` methods from `java.lang.Object` that we have discussed. (Remember, `Object` is the superclass of all classes.)

## Superclasses and interfaces

We also implement polymorphism by:

- extending a parent class (a `String` isA `Object`)
- implementing an interface (an `ArrayList` isA `List` isA `Collection` isA `Iterable`)

# Inheritance

Inheritance is the mechanism whereby a class *inherits* behavior from a superclass. We call this *extending* the superclass. Recall that all classes, whether we tell them to or not, implicitly extend `Object`.

Sometimes we create types (classes) that only exist so that they may be extended. We use the keyword `abstract` to create these *abstract classes*, which may also declare `abstract` methods.

The Java Collections Framework has several great examples of using inheritance and polymorphism: the `Collection`s, `List`s, and `Map`s that you know and love.

## In our code

Inheritance is what allows `String` concatenation to work without us doing anything extra (though perhaps it ain't pretty). Like when we do this:

```java
VirtualPet pet = new VirtualPet();
System.out.println("My pet is " + pet);
```

What happens behind the scenes is that the `toString()` method of `Object` (`VirtualPet`'s parent class) is being called. `VirtualPet` has *inherited* this method from its parent.

# Encapsulation

Encapsulation at its simplest is hiding away information that isn't necessary to share. The more knowledge we have about an object, the more complex our problem solving becomes.

*Knowledge is power. Power corrupts.*

## In our code

```java
public class Circle {
	private double radius;
	public double getRadius() {
		return radius;
	}
}
```

The `radius` instance variable above is private and exposed via an *accessor* method (`getRadius`). Not only does this avoid `radius` being manipulated externally and possibly resulting in an invalid state, but also gives us the flexibility to implement `getRadius` in a different way if necessary. The code that asks our `Circle` object for the radius doesn't need to know *how* the radius is being determined.

This is *encapsulation*. A more complex example of encapsulation would be an object responsible for calculating sales tax for a transaction. If the formula changes, yet it is encapsulated within the object, other objects requesting the tax calculation need not change. This would also likely involve polymorphism, since sales tax calculations vary by a number of factors, including location and product type.

# Gratuitous Picture of Pie

<p><img src="./resources/apple-pie.jpg" style="max-height: 50rem;"></p>
